\ Copyright 2021 Bradley D. Nelson
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

e: test-f.
  123e f. cr
  out: 123.000000 
  123.123e f. cr
  out: 123.123000 
  -123.123e f. cr
  out: -123.123000 
;e

e: test-f+
  123e 11e f+ f. cr
  out: 134.000000 
;e

e: test-f*
  123e 10e f* f. cr
  out: 1230.000000 
;e

e: test-1/f
  100e 1/f f. cr
  out: 0.009999 
;e

e: test-f/
  1000e 4e f/ f. cr
  out: 250.000000 
;e

e: test-fsqrt
  256e fsqrt f. cr
  out: 16.000000 
;e

e: test-fswap
  123e 234e fswap f. f. cr
  out: 123.000000 234.000000 
;e

e: test-fover
  123e 234e fover f. f. f. cr
  out: 123.000000 234.000000 123.000000 
;e