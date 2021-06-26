<img src="https://github.com/federicorosso1993/Kamyroll-CSharp/blob/master/img_title.png" width="20%"></img>

## Description
Simple C# conversion of https://github.com/hyugogirubato/Kamyroll-Python \n
It will be a little different from the original source to be as basic as possible (it will not store any config.json and it will not support download seasons (just simple episode)) it will only Login and download the episode if you have youtube-dl in the path you provide or in the path of the exe and save the ass subtitles of the local language for the user or the us subtitles. It will always download the best resolution it can find.\n
Apache License 2.0 the same as the original apply to Kamyroll-CSharp.

I made this to study the way Crunchyroll Beta API works and to create a better way to find any API call type without testing.


## How to use it?

.\Kamyroll-CSharp.exe --dlpath downloadpath --youtubedlpath youtube-dlpath --login username:password --download https://beta.crunchyroll.com/it/watch/episodecode/seriesname https://beta.crunchyroll.com/it/watch/episodecode/seriesname 

dlpath (optional) you can download in the path of the exe of this program \n
youtubedlpath (optional) but you need to have youtube-dl.exe and ffmpeg.exe in the path of the exe of this program \n
login (mandatory) without login crunchyroll beta cannot be used \n
download (mandatory) without a link to download there is no reason to use this program (you can download multiple episodes) \n