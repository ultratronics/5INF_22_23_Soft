#include <stdio.h>
#include <string.h>


//char a = 'e';


int main() {

  char palindroom[]= "racecar";
  char copy[8];
  /* code */
for (int i = 6; i >= 0; i--) {
  /* code */
  printf("%c\n", palindroom[i]);
  copy[6-i] = palindroom[i];
}

//test copy

printf("%s\n",copy);
if (strcmp(palindroom,copy) == 0){
printf("ze zijn gelijk\n");

}else{

  printf("ze zijn niet gelijk\n");
}

  return 0;
}

