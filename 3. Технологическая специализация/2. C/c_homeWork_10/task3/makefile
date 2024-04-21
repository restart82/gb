all: prog.exe
	.\prog.exe
	
prog.exe: main.o fileManager.o task.o
	gcc -o prog task.o fileManager.o main.o
	del *.o

main.o: main.c
	gcc -c -o main.o main.c

funk.o: task.c
	gcc -c -o task.o task.c

fileManager.o: fileManager.c
	gcc -c -o fileManager.o fileManager.c

clean:
	del *.exe
	del *.o