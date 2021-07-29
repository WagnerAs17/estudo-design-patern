using System;
using System.IO;
using System.Security.Cryptography;

namespace Estrutura_Dados.Estruturais._03___Decorator
{
    class EncryptDecorator : DataSourceDecorator
    {
        public EncryptDecorator(IDataSource dataSource)
            : base(dataSource)
        {
        }

        public override void WriteData(object data)
        {
            data = (string)data;

            var caminho = Environment.CurrentDirectory;

            var filePath = caminho + @"\crypt.txt";

            var cspp = new CspParameters();
            var aes = Aes.Create();
            var transform = aes.CreateEncryptor();

            var rsa = new RSACryptoServiceProvider(cspp);

            var keyEncrypted = rsa.Encrypt(aes.Key, false);

            var lenK = new byte[4];
            var lenIV = new byte[4];

            var lkey = keyEncrypted.Length;
            lenK = BitConverter.GetBytes(lkey);

            int lIV = aes.IV.Length;

            lenIV = BitConverter.GetBytes(lIV);
            var startFile = filePath.LastIndexOf("\\") + 1;
            var outFile = caminho + filePath.Substring(startFile, filePath.LastIndexOf(".") - startFile) + ".enc";

            using (var outFs = new FileStream(outFile, FileMode.Create))
            {
                outFs.Write(lenK, 0, 4);
                outFs.Write(lenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lkey);
                outFs.Write(aes.IV, 0, lIV);

                using (var outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {
                    int count = 0;
                    int offset = 0;

                    int blockSizeBytes = aes.BlockSize / 8;
                    var dados = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (var inFs = new FileStream(filePath, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(dados, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(dados, 0, count);
                            bytesRead += blockSizeBytes;

                        } while (count > 0);

                        inFs.Close();
                    }

                    outStreamEncrypted.FlushFinalBlock();
                    outStreamEncrypted.Close();
                }

                outFs.Close();
            }
        }
    }
}
