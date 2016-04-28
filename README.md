# MusicBrainz ![Build Status](https://travis-ci.org/Zastai/MusicBrainz.svg?branch=master)

These are .NET implementations of libmusicbrainz and libdiscid.
Both will use the same major & minor revision as the corresponding C/C++ libraries, but their own patch level.

NuGet packages will be created for both libraries.

## MetaBrainz.MusicBrainz.dll

This assembly corresponds to the libmusicbrainz library.
An attempt will be made to keep the same class hierarchy.

## MetaBrainz.MusicBrainz.DiscId.dll

This assembly corresponds to the libdiscid library. For the moment, it uses PInvoke to access Windows APIs.
Support for other platforms (whether via mono or coreclr) is not immediately planned, but may be added later;
an attempt has been made to define most relevant structures based on the NCITS T10/1363-D standard (rather than
just copying the Windows API structs), so that as little as possible resides in the WinApi class.

### DiscId.exe

This is a small sample program using MetaBrainz.MusicBrainz.DiscId.dll.