all: find_maximum.exe
	
find_maximum.exe: main.o funk.o
	gcc -o find_maximum funk.o main.o
	del *.o

main.o: main.c
	gcc -c -o main.o main.c

funk.o: funk.c
	gcc -c -o funk.o funk.c

clean:
	del *.exe