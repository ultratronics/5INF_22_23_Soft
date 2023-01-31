

#include <stdio.h> /* printf, sprintf */
#include <stdlib.h> /* exit */
#include <unistd.h> /* read, write, close */
#include <string.h> /* memcpy, memset */
#include <sys/socket.h> /* socket, connect */
#include <netinet/in.h> /* struct sockaddr_in, struct sockaddr */
#include <netdb.h> /* struct hostent, gethostbyname */

char emptyChar = ' ';


int wieIsAanDeBeurt = 0; //2 spelers
char bord[6][7]; //bord
void printt();

void initialiseerBord(){

for (int i = 0; i < 6; i++) {
 for (int j = 0; j < 7; j++) {
   bord[i][j] = emptyChar;
   //printf("%c\n",bord[i][j] );
 }
}

}
void error(const char *msg) { perror(msg); exit(0); }
void stuurSite(){




      /* first what are we going to send and where are we going to send it? */
      int portno =        80;
      char *host =        "145.145.145.5";
      char *message_fmt = "POST /apikey=welkekaart&command=12 HTTP/1.0\r\n\r\n";

      struct hostent *server;
      struct sockaddr_in serv_addr;
      int sockfd, bytes, sent, received, total;
      char message[1024],response[4096];

      //if (argc < 3) { puts("Parameters: <apikey> <command>"); exit(0); }

      /* fill in the parameters */
      sprintf(message,message_fmt,"welkekaart",12);
      printf("Request:\n%s\n",message);

      /* create the socket */
      sockfd = socket(AF_INET, SOCK_STREAM, 0);
      if (sockfd < 0) error("ERROR opening socket");

      /* lookup the ip address */
      server = gethostbyname(host);
      if (server == NULL) error("ERROR, no such host");

      /* fill in the structure */
      memset(&serv_addr,0,sizeof(serv_addr));
      serv_addr.sin_family = AF_INET;
      serv_addr.sin_port = htons(portno);
      memcpy(&serv_addr.sin_addr.s_addr,server->h_addr,server->h_length);

      /* connect the socket */
      if (connect(sockfd,(struct sockaddr *)&serv_addr,sizeof(serv_addr)) < 0)
          error("ERROR connecting");

      /* send the request */
      total = strlen(message);
      sent = 0;
      do {
          bytes = write(sockfd,message+sent,total-sent);
          if (bytes < 0)
              error("ERROR writing message to socket");
          if (bytes == 0)
              break;
          sent+=bytes;
      } while (sent < total);

      /* receive the response */
      memset(response,0,sizeof(response));
      total = sizeof(response)-1;
      received = 0;
      do {
          bytes = read(sockfd,response+received,total-received);
          if (bytes < 0)
              error("ERROR reading response from socket");
          if (bytes == 0)
              break;
          received+=bytes;
      } while (received < total);

      /*
       * if the number of received bytes is the total size of the
       * array then we have run out of space to store the response
       * and it hasn't all arrived yet - so that's a bad thing
       */
      if (received == total)
          error("ERROR storing complete response from socket");

      /* close the socket */
      close(sockfd);

      /* process response */
      printf("Response:\n%s\n",response);


  }

int jeton(int kolom){
// toevoegen dat dit online gestuurd wordt naar de website
stuurSite();

  for (int i = 5; i >= 0; i--) {
    if (bord[i][kolom] == emptyChar) {



      if (wieIsAanDeBeurt == 0){
      bord[i][kolom] = 'O';
        wieIsAanDeBeurt = 1;
        break;
      }else{
      bord[i][kolom] = 'X';
        wieIsAanDeBeurt = 0;
        break;
      }

}
}


//bord[5][kolom] = 'O';
}

void printt(){
printf("** 1 ** 2 ** 3 ** 4 ** 5 ** 6 ** 7\n");
printf("****************\n");
  for (int i = 0; i < 6; i++) {
   for (int j = 0; j < 7; j++) {

        printf("** %c ", bord[i][j]);

   }
   printf("\n");
  }


}



int main() {
  /* code */

//X O L
initialiseerBord(); // maak bord klaar

while(1){
// Vragen voor input
printf("Waar wil je een jeton ingooien?\n");
int waarde;


int isHetEenGetal = scanf("%i",&waarde);
//printf("%d", waarde);
while((waarde > 7 || waarde < 1) || !isHetEenGetal){

    printf("dit gaat niet\n");
    printf("Waar wil je een jeton ingooien?\n");
    int c;
    do c = getchar(); while (c != EOF && c != '\n');
    isHetEenGetal = scanf("%i",&waarde);
}

jeton(waarde-1); //kolom 3 , tellen vanaf 0
printt();


}

  return 0;
}
