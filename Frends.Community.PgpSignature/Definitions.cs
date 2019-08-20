﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#pragma warning disable 1591

namespace FRENDS.Community.PgpSignature
{
    public class Input
    {
        /// <summary>
        /// Path to file to sign.
        /// </summary>
        [DefaultValue(@"C:\temp\message.txt")]
        [DisplayFormat(DataFormatString = "Text")]
        public string InputFile { get; set; }
        /// <summary>
        /// Path to signed file that will be created.
        /// </summary>
        [DefaultValue(@"C:\temp\signature.txt")]
        [DisplayFormat(DataFormatString = "Text")]
        public string OutputFile { get; set; }
        /// <summary>
        /// Path to private key file.
        /// </summary>
        [DefaultValue(@"C:\temp\publicKey.asc")]
        [DisplayFormat(DataFormatString = "Text")]
        public string PrivateKeyFile { get; set; }
        /// <summary>
        /// Password attached to private key.
        /// </summary>
        [PasswordPropertyText]
        public string Password { get; set; }
        /// <summary>
        /// Hash (digest) function, such as SHA256, SHA384, SHA512, MD5, RIPEMD160, SHA1.
        /// </summary>
        // public HashAlgorithmTag HashFunction { get; set; }
        [DefaultValue(HashFunctionType.Sha256)]
        public HashFunctionType HashFunction { get; set; }
    }

    /// <summary>
    /// Enum for choosing HashAlgorithm type.
    /// </summary>
    public enum HashFunctionType
    {
        MD5,
        Sha1,
        RipeMD160,
        Sha224,
        Sha256,
        Sha384,
        Sha512
    }


    public class Result
    {
        /// <summary>
        /// Result class.
        /// </summary>
        public string FilePath { get; set; }
    }



}