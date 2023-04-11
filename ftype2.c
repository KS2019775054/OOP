#include <unistd.h>
 #include <stdlib.h>
 #include <stdio.h>
 #include <string.h>
 #include <sys/stat.h>
 void print_binary(unsigned int num) { if (num > 1) {
	  print_binary(num/2);
	   }
  printf("%d", num % 2);
   }
 int main(int argc, char *argv[]) {
	 
	int i;
	for (i = 1; i < argc; i++) {
		
		struct stat buf;
		if (lstat(argv[i], &buf) < 0) { perror("lstat()");
			continue;
		  }
		printf("%s: ", argv[i]);
		if (S_ISREG(buf.st_mode))
		      	printf("%s \n", "일반 파일");
		if (S_ISDIR(buf.st_mode))
		      	printf("%s \n", "디렉터리");
		if (S_ISCHR(buf.st_mode))
			printf("%s \n", "문자 장치 파일");
		if (S_ISBLK(buf.st_mode))
			printf("%s \n", "블록 장치 파일");
		if (S_ISFIFO(buf.st_mode))
			printf("%s \n", "FIFO 파일");
		if (S_ISLNK(buf.st_mode))
			printf("%s \n", "심볼릭 링크");
		if (S_ISSOCK(buf.st_mode))
			printf("%s \n", "소켓");
		printf("이진수 출력: ");
		print_binary((unsigned int)argv[i][0]); printf("\n");
		}
	   exit(0);
	    }
