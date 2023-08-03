using System;
using System.IO;
using System.Security.Cryptography;

// namespace Csharp
public class DecrEncr
{

    private static byte[] _key = {
                            0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                            0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
                        };

    private static byte[] _iv;

    public static void Main()
    {
        // EncryptFile(AppContext.BaseDirectory + "sample.txt");

    }

    // Symmetric - to encrypt big data like streams or files and sent over network or similar
    public void EncryptFile(string filename)
    {
        try
        {
            // File.Copy(filename, filename + "_orgnl", true);

            using (FileStream fileStream = new(filename, FileMode.OpenOrCreate))
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = _key;

                    _iv = aes.IV;
                    fileStream.Write(_iv, 0, _iv.Length);

                    using (CryptoStream cryptoStream = new(
                        fileStream,
                        aes.CreateEncryptor(),
                        CryptoStreamMode.Write))
                    {
                        // By default, the StreamWriter uses UTF-8 encoding.
                        // To change the text encoding, pass the desired encoding as the second parameter.
                        // For example, new StreamWriter(cryptoStream, Encoding.Unicode).
                        using (StreamWriter encryptWriter = new(cryptoStream))
                        {
                            encryptWriter.WriteLine("Hello World!");
                        }
                    }

                }

                Console.WriteLine("The file was encrypted. " + _iv.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Encryption failed " + ex);
        }

    }

    public static void EncryptFile_(string filename)
    {
        try
        {
            using (FileStream fileStream = new("TestData.txt", FileMode.OpenOrCreate))
            {
                using (Aes aes = Aes.Create())
                {
                    byte[] key =
                    {
                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
            };
                    aes.Key = key;

                    byte[] iv = aes.IV;
                    fileStream.Write(iv, 0, iv.Length);

                    using (CryptoStream cryptoStream = new(
                        fileStream,
                        aes.CreateEncryptor(),
                        CryptoStreamMode.Write))
                    {
                        // By default, the StreamWriter uses UTF-8 encoding.
                        // To change the text encoding, pass the desired encoding as the second parameter.
                        // For example, new StreamWriter(cryptoStream, Encoding.Unicode).
                        using (StreamWriter encryptWriter = new(cryptoStream))
                        {
                            encryptWriter.WriteLine("Hello World!");
                        }
                    }
                }
            }

            Console.WriteLine("The file was encrypted.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"The encryption failed. {ex}");
        }
    }

    public async void DecryptFile(string filename)
    {
        try
        {
            using (FileStream fileStream = new(filename, FileMode.Open))
            {
                using (Aes aes = Aes.Create())
                {
                    _iv = new byte[aes.IV.Length];
                    int numBytesToRead = aes.IV.Length;
                    if(_iv == null)
                    {
                        // _iv = aes.IV;
                    }

                    // int numBytesToRead = _iv.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        int n = fileStream.Read(_iv, numBytesRead, numBytesToRead);
                        if (n == 0) break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }

                    using (CryptoStream cryptoStream = new(
                       fileStream,
                       aes.CreateDecryptor(_key, _iv),
                       CryptoStreamMode.Read))
                    {
                        // By default, the StreamReader uses UTF-8 encoding.
                        // To change the text encoding, pass the desired encoding as the second parameter.
                        // For example, new StreamReader(cryptoStream, Encoding.Unicode).
                        using (StreamReader decryptReader = new(cryptoStream))
                        {
                            string decryptedMessage = await decryptReader.ReadToEndAsync();
                            Console.WriteLine($"The decrypted original message: {decryptedMessage}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"The decryption failed. {ex}");
        }
    }

    // to encrypt small data like keys and iv info to transit later
    public static void AssymetricEncryption()
    {
        //Initialize the byte arrays to the public key information.
        byte[] modulus =
        {
            214,46,220,83,160,73,40,39,201,155,19,202,3,11,191,178,56,
            74,90,36,248,103,18,144,170,163,145,87,54,61,34,220,222,
            207,137,149,173,14,92,120,206,222,158,28,40,24,30,16,175,
            108,128,35,230,118,40,121,113,125,216,130,11,24,90,48,194,
            240,105,44,76,34,57,249,228,125,80,38,9,136,29,117,207,139,
            168,181,85,137,126,10,126,242,120,247,121,8,100,12,201,171,
            38,226,193,180,190,117,177,87,143,242,213,11,44,180,113,93,
            106,99,179,68,175,211,164,116,64,148,226,254,172,147
        };

        byte[] exponent = { 1, 0, 1 };

        //Create values to store encrypted symmetric keys.
        byte[] encryptedSymmetricKey;
        byte[] encryptedSymmetricIV;

        //Create a new instance of the RSA class.
        RSA rsa = RSA.Create();

        //Create a new instance of the RSAParameters structure.
        RSAParameters rsaKeyInfo = new RSAParameters();

        //Set rsaKeyInfo to the public key values.
        rsaKeyInfo.Modulus = modulus;
        rsaKeyInfo.Exponent = exponent;

        //Import key parameters into rsa.
        rsa.ImportParameters(rsaKeyInfo);

        //Create a new instance of the default Aes implementation class.
        using Aes aes = Aes.Create();

        //Encrypt the symmetric key and IV.
        encryptedSymmetricKey = rsa.Encrypt(_key, RSAEncryptionPadding.Pkcs1);
        encryptedSymmetricIV = rsa.Encrypt(aes.IV, RSAEncryptionPadding.Pkcs1);
    }
}