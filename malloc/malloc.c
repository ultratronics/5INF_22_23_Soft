#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main() {
  char *a = malloc(sizeof(char) * 10);
  strcpy(a, "driller");
  printf("%s\n", a );
  a = realloc(a, sizeof(char) * 20);
  strcpy(a, "hottentottententent");
  printf("%s\n", a);


  free(a);
  return 0;
}

