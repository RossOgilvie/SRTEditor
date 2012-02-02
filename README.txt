README for SRT Editor
Programmed by Ross Ogilvie - ross@rossogilvie.id.au

Hello! 

This program is designed to aid you in translating srt subtitle files. It will probably be useful in understanding the layout of the editor if you understand how srt files work. An srt file is very simple, let me give you a sample.

====================================
HOW SRT FILES WORK
====================================

28
00:01:31,765 --> 00:01:33,323
Oh, please, let it be soon.

29
00:01:33,634 --> 00:01:35,261
(DOORBELL RlNGS)
That's for me.

30
00:01:38,005 --> 00:01:39,905
Hi.
You promise to be good?

As you can see, it is just a sequence of blocks of text. Each block is separated by a blank line. The first line of the block is just a count of where we are up to. The second line is the timing information; it dictates when this subtitle will be shown on the screen. The lines after this is what is shown on the screen. It can be multiple lines, but may not contain a blank line (otherwise it thinks we've moved on to the next block).

====================================
GETTING STARTED
====================================

When you first run the editor, it will be all blank. Click the "English Subtitles" button to select the English subtitle file. It will appear in the left panel. Next click the "Lojban Subtitles" button and select the Lojban subtitle file. If you are starting a new translation project, I suggest just making a copy of the English subtitle file and use the copy as the lojban file to give you all the timing information, then as you translate you replace the English with Lojban.

The "Output of dual subtitles" is an extra feature, explained in the extra features section

When the files are loaded, the editor shows you one block at a time from each file, side by side for ease of translating. You can move backward and forward through each file individually by using the arrow buttons immediately below the respective subtitle box. More commonly though use the "Previous" and "Next" buttons to move both forward and backward together.

*PRO TIP* Clicking buttons is a pain in the arse. The shortcut for the "Previous" and "Next" buttons is Alt+Left and Alt+Right respectively. To move just the Lojban subtitles back and forth you can use Alt+Up and Alt+Down

You can now use the editor. Put your translation in the right hand panel, move to the next subtitle, repeat until done. When you grow weary, and also at regular intervals, click the "Save" button to save the lojban subtitles to the lojban subtitles file. No changes to the english subtitles will be saved.

If you need to move a large distance through the subtitles, use the "Jump" button. You can change how far you jump by changing the number in the box that is within the jump button. To jump backward, change it to a negative number.

I have now explained the important buttons, if you still have questions about how things work please email me (email at top of document), or if I set up some form of bug tracking use that.

====================================
POTENTIAL ISSUES
====================================

So I am sure that you guys will find bugs in my program, or think of awesome tweaks to improve it. Please feel free to give me feedback like this. I will try to implement it, time permitting.

I think most of the bugs will be related to file operations (loading and saving). I have tried to stop the program crashing when these happen, but no guarantees. 

The other thing that is likely to fail is the bit of code that tries to remember what you were doing last time. It is a new feature and not tested thoroughly (even as I was writing this sentence I went and tweaked it). If it fails, I've tried to make it do so unobtrusively.

DON"T PUT BLANK LINES IN THE RIGHT HAND SUBTITLE BOX! They'll end up as blank line in the srt file, and as you already learnt why that is bad.

====================================
EXTRA FEATURES
====================================

First up, I've already mentioned the "Dual Output" feature. If you select a path to put this subtitle file with the  "Output of dual subtitles" button and then press the "Output Dual" button at the bottom then it creates a set of subtitles that have both English and Lojban shown. This can be useful for watching through the movie and checking that the meaning of the lojban and the english match in context.

Next up is you can change the timing of each subtitle just by altering the timing box. The format is 
hh:mm:ss,ttt --> hh:mm:ss,ttt
where the bits after the commas are milliseconds (is there are standard one letter abbreviation for milliseconds?). It must be this exact format otherwise they may not be displayed correctly. Also, if subtitles timings overlap, VLC doesn't show them both and the result is likely to depend on the program playing the video, so don't do that.

Finally that brings us to the "Delete" and "Insert" buttons. These do exactly what they say. Insert will make a new frame after the current one and delete will delete the current subtitle. This is capable of wrecking alot of things, and there is no undo button so save before you do one of there operations, maybe even make backups of the files. Also, try not to insert extra frames if you can avoid, as it will must the two files out of sync. Of course you could progress each subtitle individually to line them back up (that is the reason that ability exists), but from experience this is a pain to do.

There are 

====================================
ENJOY
====================================