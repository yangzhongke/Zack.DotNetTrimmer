#include <stdlib.h>
#include <stdio.h>
#include <yzkgame.h>

#pragma comment( linker, "/subsystem:\"console\" /entry:\"mainCRTStartup\"" )
#pragma comment(lib, "YZKGame.lib")

void gameMain(void)
{
	setGameTitle("YZKGame");
	setGameSize(338, 600);
	pauseGame(10000);
}

int main(void)
{
	rpInit(gameMain);
	return 0;
}