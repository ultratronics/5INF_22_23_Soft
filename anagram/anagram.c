#include <stdio.h>
char woordje[] = "top";
char woordje2[] = "pft";

int som1 = 0;
int som2 = 0;

int main() {

for (int i = 0; i < 3; i++) {
  som1 = som1 + woordje[i];
  som2 = som2 + woordje2[i];
}

if (som1 == som2 ) {
  printf("voila ik heb een anagram\n");
}

  return 0;
}
