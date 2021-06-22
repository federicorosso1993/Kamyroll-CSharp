Simple C# conversion of https://github.com/hyugogirubato/Kamyroll-Python
It will be a little different from the original source to be as basic as possible (it will not store any config.json and it will not support download seasons and movies (just simple episode)) it will only Login and display the info that youtube need to download the episode and show the ass subtitles of the local language for the user on the console.
Apache License 2.0 the same as the original apply to Kamyroll-CSharp.

I made this to study the way Crunchyroll Beta API works and to create a better way to find any API call type without testing.


How to use it?
 .\Kamyroll-CSharp.exe --login username:password --download https://beta.crunchyroll.com/it/watch/episodecode/Title

 you will get:
 link to download the episode with youtube-dl

 sub of your language printed on the console, copy and paste in a notepad and save in .ass

youtube-dl.exe "link"