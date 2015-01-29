using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Deco
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Stream originalStream = new FileStream(@"c:\temp\test.bin", FileMode.Create, FileAccess.Write))
            {
                EventingStreamDecorator wrappedStream1 = new EventingStreamDecorator(originalStream);
                wrappedStream1.OnWriteEvent += () => { Console.WriteLine("Write occured"); };
                XoringStreamDecorator wrappedStream2 = new XoringStreamDecorator(wrappedStream1);
               // StreamWriter sq = new StreamWriter(esd);
                XoringStreamDecorator wrappedStream3 = new XoringStreamDecorator(wrappedStream2);









                byte[] wr = new byte[] {65, 66, 67};
                wrappedStream3.Write(wr, 0, 3);
            }
            
        }
    }

    public abstract class StreamDecorator : Stream
    {
        private Stream _originalStream;

        public StreamDecorator(Stream originalStream)
        {
            _originalStream = originalStream;
        }

        public override bool CanRead
        {
            get { return
                _originalStream.CanRead;
            }
        }

        public override bool CanSeek
        {
            get { return _originalStream.CanSeek; }
        }

        public override bool CanWrite
        {
            get { return _originalStream.CanWrite; }
        }

        public override void Flush()
        {
            _originalStream.Flush();
        }

        public override long Length
        {
            get { return _originalStream.Length; }
        }

        public override long Position
        {
            get { return _originalStream.Position; }
            set
            {
                _originalStream.Position = value;
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return _originalStream.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _originalStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _originalStream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _originalStream.Write(buffer, offset, count);
        }
    }


    public class EventingStreamDecorator : StreamDecorator
    {
        public delegate  void WriteNotification();

        public event WriteNotification OnWriteEvent = () => { };
        public EventingStreamDecorator(Stream originalStream) : base(originalStream)
        {
            
        }

        

        public override void Write(byte[] buffer, int offset, int count)
        {
            OnWriteEvent();
            base.Write(buffer, offset, count);
        }
    }

    public class XoringStreamDecorator : StreamDecorator
    {
        public XoringStreamDecorator(Stream originalStream) : base(originalStream)
        {
            
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            // xor the buffer.
            int a = 1;

            for (int x = 0; x < count; x++)
            {
                buffer[x] ^= 0xFF;
            }

            base.Write(buffer, offset, count);
        }
    }
}
