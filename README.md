# Atelier Meruru Date Transfer Tool
Transfer the date information from one saved game to another

# Description, pretty much copy/pasted from the program and there's a chance this description is obsolete
Warning: this program literally breaks the laws of the universe, the universe inside Atelier Meruru. As such, please treat this as a hacking tool. I also offer no warranty about using program, even if the creators of Atelier Meruru decide to change the saved game file format. Please enjoy responsibly and try not to blow up the universe too much. No warranties against harm or damage

Try to save the game, do whatever in the game takes up a lot of time, then save now to 2 different slots. Slot #2 is your backup in case this tool really screws over the save, but I didn't find that necessary. 

I could try making the day setting more precise, but the saved game is encrypted with what looks like a bit shifting pattern. This tool basically transfer the date information from the input file to the output file instead. This program may transfer flags over, so you might only want to rewind a few weeks ago when there are no events happening outside any income that comes from certain investments. 

You do something that spends a lot of time like synthesizing, and when nothing happens when you walk out and back into the Atelier, it's a good point to rewind to. I did this, and I beat the game using this tool. There's also plenty of safe points to rewind. This tool does not transfer the year over. 

If Steam Cloud Save messes up your save, try modifying the save while the game is running, then immediately load the game after you modify it. It doesn't matter if the date reads correctly in the game UI

# Extra information not copy/pasted from the program

This program is made open source because the Internet can be scary, so here's the sauce. It basically takes a few bytes and plops them into the other save. The code should be straightforward enough so that anyone decent at programming should be able to replicate it

# Findings and notes. SPOILERS AHEAD
* Many events in the game are based on the days passing, not the absolute date. For example, if you ask a Hom to do something, 7 days passed, you rewind, the game will act like 6-7 have passed. The same goes for tavern quests
* This breaks many facets of the game. For example, the income you get from shops keeps happening on those days of the month
* I haven't tried to use this tool to intentionally break the game too much
* If you exceed the end date on the last year, the game over sequence starts
* I just experimented with rewinding the year. I just figured out how to do it. It introduced a bug. I rewinded from Year 5 to Year 2. Once it went from the end of Year 2 to the next day, it stayed Year 2. Yeah, that's not the ideal situation. Maybe from Year 5 to Year 4 won't be as bad
* I pretty much limited myself for 2-6 weeks of a rewind to be safe. Again, made sure no major events happened during the rewind
