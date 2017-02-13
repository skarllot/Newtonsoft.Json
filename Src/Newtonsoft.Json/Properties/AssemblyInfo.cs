#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
#if NETSTANDARD1_0
[assembly: AssemblyTitle("Json.NET .NET Standard 1.0")]
#elif NETSTANDARD1_3
[assembly: AssemblyTitle("Json.NET .NET Standard 1.3")]
#elif NETSTANDARD1_1
[assembly: AssemblyTitle("Json.NET .NET Standard 1.1")]
#elif PORTABLE40
[assembly: AssemblyTitle("Json.NET Portable .NET 4.0")]
#elif PORTABLE
[assembly: AssemblyTitle("Json.NET Portable")]
#elif DOTNET
[assembly: AssemblyTitle("Json.NET .NET Platform")]
#elif NET20
[assembly: AssemblyTitle("Json.NET .NET 2.0")]
[assembly: AllowPartiallyTrustedCallers]
#elif NET35
[assembly: AssemblyTitle("Json.NET .NET 3.5")]
[assembly: AllowPartiallyTrustedCallers]
#elif NET40
[assembly: AssemblyTitle("Json.NET .NET 4.0")]
[assembly: AllowPartiallyTrustedCallers]
#elif WindowsCE
[assembly: AssemblyTitle("Json.NET .NET Compact 3.5")]
#else
[assembly: AssemblyTitle("Json.NET")]
[assembly: AllowPartiallyTrustedCallers]
#endif

[assembly: InternalsVisibleTo("Newtonsoft.Json.Schema, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f561df277c6c0b497d629032b410cdcf286e537c054724f7ffa0164345f62b3e642029d7a80cc351918955328c4adc8a048823ef90b0cf38ea7db0d729caf2b633c3babe08b0310198c1081995c19029bc675193744eab9d7345b8a67258ec17d112cebdbbb2a281487dceeafb9d83aa930f32103fbe1d2911425bc5744002c7")]
[assembly: InternalsVisibleTo("Newtonsoft.Json.Tests, PublicKey=00240000048000001402000006020000002400005253413100100000010001002d0bf3a319ee3ac3bf1e2ab86e68a579d2664e25f90dde08805439e8f2d059d59dc18b27edac451faa883c9fbbaf9fadae327d39a5a6c5e2935c9ebe937de28ba4be8c67a56195deff13194835558e5d47a735415837cbaed2b68cc67f1842a30802f29f315de5e202123998b172e71970929e38bab7bac164fec07e7a3c55edbc8046d7a34785647af0b191a39c324f7d7cc6867e27235ce3817cf4ad24bfd79db2eb7e4536be4f73560261b274cc4fd50e7dcd19c6b82e8b0108ae72335e47242953935015bd883735a94dbf730027a35e095442703e32db7f233f47933ac3c4674b7d8193059f9ee4044b1d91d0a0158cd992e71598bd19b04cedc0adf78f2c46b6b3c3eaf5c7b23cad2785b3fa7fa36a39a6408a9af9e834bb308f56c448ef57ee50d58da001ce9914c74201dc42331ae1c4257aeaf6ed91efca0578f9e62a9566d3f96341c2fc6bd13628ecc28354f7b35182dfb7b3305e69984122c676e8febeb80ae29a0728b4cb959f4540f46fb1b9fca6bb1dae93d2d800f14ea357a953deb16df3f058d335163c5328667a291640d4361df02a405eb94f8eee45513660a4063f7a9b3dd3899753f10cdb10c2a337999a9ac82d634437958694391ef159ee19588846c5dafdd9669d337f8394ee1aa0042e9d6baae88d279ecb2e9007d4e078c2b8763cea6ec8a47030eb2cf4db12462071d8542d1c51e2256543e4")]

[assembly: InternalsVisibleTo("Newtonsoft.Json.Dynamic, PublicKey=0024000004800000940000000602000000240000525341310004000001000100cbd8d53b9d7de30f1f1278f636ec462cf9c254991291e66ebb157a885638a517887633b898ccbcf0d5c5ff7be85a6abe9e765d0ac7cd33c68dac67e7e64530e8222101109f154ab14a941c490ac155cd1d4fcba0fabb49016b4ef28593b015cab5937da31172f03f67d09edda404b88a60023f062ae71d0b2e4438b74cc11dc9")]
[assembly: AssemblyDescription("Json.NET is a popular high-performance JSON framework for .NET")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Newtonsoft")]
[assembly: AssemblyProduct("Json.NET")]
[assembly: AssemblyCopyright("Copyright © James Newton-King 2008")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

#if HAVE_COM_ATTRIBUTES
// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components. If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM

[assembly: Guid("9ca358aa-317b-4925-8ada-4a29e943a363")]
#endif

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion("9.0.0.0")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyFileVersion("9.0.2.7010")]
[assembly: AssemblyInformationalVersion("9.0.2-beta20170212")]
