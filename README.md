POGOProtos [![Build Status](https://travis-ci.org/AeonLucid/POGOProtos.svg?branch=master)](https://travis-ci.org/AeonLucid/POGOProtos) [![Code Climate](https://codeclimate.com/github/AeonLucid/POGOProtos/badges/gpa.svg)](https://codeclimate.com/github/AeonLucid/POGOProtos) [![Issue Count](https://codeclimate.com/github/AeonLucid/POGOProtos/badges/issue_count.svg)](https://codeclimate.com/github/AeonLucid/POGOProtos)
===================

This repository contains the [ProtoBuf](https://github.com/google/protobuf) `.proto` files needed to decode the Pok�monGo RPC.

If you want to know which messages are implemented right now, click [here](https://github.com/AeonLucid/POGOProtos/blob/master/src/POGOProtos/Networking/Requests/RequestType.proto).

# Usage

## Versioning

We are following [semantic versioning](http://semver.org/) for POGOProtos.  Every version will be mapped to their current Pok�monGo version.

| Version      | Android       | IOS           |
|--------------|---------------|---------------|
| 2.0.0        | 0.43.4        | 1.13.4        |

## Preparation

Current recommended protoc version: "Protocol Buffers v3.1.0".

You can find download links [here](https://github.com/google/protobuf/releases).

### Windows
Be sure to add `protoc` to your environmental path.

### *nix
Ensure that you have the newest version of `protoc` installed.

### OS X
Use `homebrew` to install `protobuf ` with `brew install --devel protobuf`.

## Compilation
The compilation creates output specifically for the target language, i.e. respecting naming contentions, etc.  
This is an example of how the generated code will be organized:

`python compile_pretty.py cpp`:
 - `POGOProtos/Data/PlayerData.proto` -> `POGOProtos/Data/PlayerData.pb.cpp`

`python compile_pretty.py csharp`:
 - `POGOProtos/Data/PlayerData.proto` -> `POGOProtos/Data/PlayerData.g.cs`
 
`python compile_pretty.py go`:
 - `POGOProtos/Data/*.proto` -> `github.com/aeonlucid/pogoprotos/data`
 - `POGOProtos/Data/PlayerData.proto` -> `github.com/aeonlucid/pogoprotos/data/player_data.pb.go`

`python compile_pretty.py java`:
 - `POGOProtos/Data/*.proto` -> `com/github/aeonlucid/pogoprotos/Data.java`
 
`python compile_pretty.py js`:
 - `POGOProtos/**/*.proto` -> `pogoprotos.js`

`python compile_pretty.py objc`:
 - `POGOProtos/Data/PlayerData.proto` -> `POGOProtos/Data/PlayerData.pbobjc.m`
 
`python compile_pretty.py python`:
 - `POGOProtos/Data/*.proto` -> `pogoprotos/data/__init__.py`
 - `POGOProtos/Data/PlayerData.proto` -> `pogoprotos/data/player_data_pb2.py`

`python compile_pretty.py ruby`:
 - `POGOProtos/Data/*.proto` -> `pogoprotos/data.rb`
 - `POGOProtos/Data/PlayerData.proto` -> `pogoprotos/data/player_data.rb`

#### Command

Run `python compile.py --help` for help.

### Extra information
You can find all available languages here [https://github.com/google/protobuf](https://github.com/google/protobuf).

# Libraries

If you don't want to compile POGOProtos but instead use it directly, check out the following repository.

| Language         | Source                                                  |
|------------------|---------------------------------------------------------|
| NodeJS           | https://github.com/rastapasta/node-pokemongo-protobuf   |
| NodeJS (pure JS) | https://github.com/cyraxx/node-pogo-protos              |
| .NET             | https://github.com/AeonLucid/POGOProtos.NetStandard1    |
| .NET             | https://github.com/johnduhart/POGOProtos-dotnet         |
| PHP              | https://github.com/jaspervdm/pogoprotos-php             |
| Go               | https://github.com/pkmngo-odi/pogo-protos               |
| Haskell          | https://github.com/relrod/pokemon-go-protobuf-types     |
| Rust             | https://github.com/rockneurotiko/pokemon-go-protobuf-rs |

# POGOProtos.NetStandard1

Precompiled protobuf files for communication with Pok�monGo.

## Supported Platforms

* .NET Standard 1.0 ([Specific platforms](https://github.com/dotnet/corefx/blob/master/Documentation/architecture/net-platform-standard.md#mapping-the-net-platform-standard-to-platforms))

## Installation
Installation is done via NuGet:

    PM> Install-Package POGOProtos.NetStandard1