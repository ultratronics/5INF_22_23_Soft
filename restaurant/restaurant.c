#include <stdio.h>

int main() {
printf("Welkom in mijn restaurant\n");
printf("Maak hier uw keuze\n" );

//char array[20][4] ={"sldfkd","sdfdsf","sdfsdf","sdfsdfsdf"};


printf("Big mac  typ 1\n");
printf("Grote friet typ 2\n");
printf("Wrap typ 3\n");
printf("vul uw keuze in:   ");
int invoer;
scanf("%d", &invoer);

if(invoer == 1){
  printf("Dat is dan 50 euro haha inflatie\n");

}else if(invoer ==2){
printf("2 euro astublieft\n");

}else{
  printf("rarara het wordt een wrap, ga naar de gevangenis\n");
}




  return 0;
}

