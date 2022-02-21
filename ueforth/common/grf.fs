( ------------------------------------------------------------ )
\ Copyright 2022 Bradley D. Nelson
\
\ Licensed under the Apache License, Version 2.0 (the "License");
\ you may not use this file except in compliance with the License.
\ You may obtain a copy of the License at
\
\     http://www.apache.org/licenses/LICENSE-2.0
\
\ Unless required by applicable law or agreed to in writing, software
\ distributed under the License is distributed on an "AS IS" BASIS,
\ WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
\ See the License for the specific language governing permissions and
\ limitations under the License.

( Generic Graphics Interface )
\ Startup:
\   window ( w h -- )
\ Drawing region:
\   pixel ( x y -- a ) (format [b g r x])
\   width ( -- n )
\   height ( -- n )
\   flip ( -- )
\ Getting events:
\   wait ( -- )
\   poll ( -- )
\ Event info:
\   mouse-x ( -- n )
\   mouse-y ( -- n )
\   last-key ( -- n )
\   last-keysym ( -- n )
\   last-keycode ( -- n )
\   event ( -- n )
\ Event constants:
\   UNKNOWN TIMEOUT RESIZE EXPOSE
\   MOTION PRESS RELEASE

vocabulary grf   grf definitions
vocabulary internals

0 constant UNKNOWN
1 constant TIMEOUT
2 constant RESIZE
3 constant EXPOSE
4 constant MOTION
5 constant PRESS
6 constant RELEASE

( Rest of definitions per platform. )

forth definitions