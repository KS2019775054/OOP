#include <stdio.h>

int main() {
	    unsigned int hex;
	        printf("16진수 입력: ");
		    scanf("%x", &hex);

		        printf("2진수 출력: ");
			    for (int i = 31; i >= 0; i--) {
				            printf("%d", (hex >> i) & 1);
					        }
			        printf("\n");

				    return 0;
}
