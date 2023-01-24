
#include <stdio.h>

int wieIsAanDeBeurt = 0; //2 spelers
char bord[6][7]; //bord
void printt();

void initialiseerBord(){

for (int i = 0; i < 6; i++) {
 for (int j = 0; j < 7; j++) {
   bord[i][j] = 'L';
   //printf("%c\n",bord[i][j] );
 }
}

}


int jeton(int kolom){

  for (int i = 5; i >= 0; i--) {
    if (bord[i][kolom] == 'L') {



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
scanf("%i",&waarde);
jeton(waarde-1); //kolom 3 , tellen vanaf 0
printt();
}

  return 0;
}
