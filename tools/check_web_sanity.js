#! /usr/bin/env nodejs
// Copyright 2022 Bradley D. Nelson
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

var fs = require('fs');
var process = require('process');

var source = fs.readFileSync('/dev/stdin').toString();

if (source.match(/Invalid/)) {
  console.log('BAD ASM.JS');
  console.log(source);
  process.exit(1)
}

if (!source.match(/[-][-][>] 123[ \r\n]+$/)) {
  console.log('MISSING EXPECTED OUTPUT');
  console.log(source);
  process.exit(1)
}
