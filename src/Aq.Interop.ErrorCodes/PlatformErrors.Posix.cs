namespace Aq.Interop {
    partial class PlatformErrors {
        public class Posix : Base {
            /* platform missing */
            public override int STRUNCATE              => int.MaxValue;
            public override int EDEADLOCK              => this.EDEADLK;
            public override int ENOTRECOVERABLE        => int.MaxValue;
            public override int EOTHER                 => int.MaxValue;
            public override int EOWNERDEAD             => int.MaxValue;

            public override int EPERM                  => 1;                /* Operation not permitted */
            public override int ENOENT                 => 2;                /* No such file or directory */
            public override int ESRCH                  => 3;                /* No such process */
            public override int EINTR                  => 4;                /* Interrupted system call */
            public override int EIO                    => 5;                /* Input/output error */
            public override int ENXIO                  => 6;                /* Device not configured */
            public override int E2BIG                  => 7;                /* Argument list too long */
            public override int ENOEXEC                => 8;                /* Exec format error */
            public override int EBADF                  => 9;                /* Bad file descriptor */
            public override int ECHILD                 => 10;               /* No child processes */
            public override int EDEADLK                => 11;               /* Resource deadlock avoided */
            public override int ENOMEM                 => 12;               /* Cannot allocate memory */
            public override int EACCES                 => 13;               /* Permission denied */
            public override int EFAULT                 => 14;               /* Bad address */
            public override int ENOTBLK                => 15;               /* Block device required */
            public override int EBUSY                  => 16;               /* Device / Resource busy */
            public override int EEXIST                 => 17;               /* File exists */
            public override int EXDEV                  => 18;               /* Cross-device link */
            public override int ENODEV                 => 19;               /* Operation not supported by device */
            public override int ENOTDIR                => 20;               /* Not a directory */
            public override int EISDIR                 => 21;               /* Is a directory */
            public override int EINVAL                 => 22;               /* Invalid argument */
            public override int ENFILE                 => 23;               /* Too many open files in system */
            public override int EMFILE                 => 24;               /* Too many open files */
            public override int ENOTTY                 => 25;               /* Inappropriate ioctl for device */
            public override int ETXTBSY                => 26;               /* Text file busy */
            public override int EFBIG                  => 27;               /* File too large */
            public override int ENOSPC                 => 28;               /* No space left on device */
            public override int ESPIPE                 => 29;               /* Illegal seek */
            public override int EROFS                  => 30;               /* Read-only file system */
            public override int EMLINK                 => 31;               /* Too many links */
            public override int EPIPE                  => 32;               /* Broken pipe */

            /* math software */
            public override int EDOM                   => 33;               /* Numerical argument out of domain */
            public override int ERANGE                 => 34;               /* Result too large */

            /* non-blocking and interrupt i/o */
            public override int EAGAIN                 => 35;               /* Resource temporarily unavailable */
            public override int EWOULDBLOCK            => this.EAGAIN;      /* Operation would block */
            public override int EINPROGRESS            => 36;               /* Operation now in progress */
            public override int EALREADY               => 37;               /* Operation already in progress */

            /* ipc/network software -- argument errors */
            public override int ENOTSOCK               => 38;               /* Socket operation on non-socket */
            public override int EDESTADDRREQ           => 39;               /* Destination address required */
            public override int EMSGSIZE               => 40;               /* Message too long */
            public override int EPROTOTYPE             => 41;               /* Protocol wrong type for socket */
            public override int ENOPROTOOPT            => 42;               /* Protocol not available */
            public override int EPROTONOSUPPORT        => 43;               /* Protocol not supported */
            public override int ESOCKTNOSUPPORT        => 44;               /* Socket type not supported */
            public override int ENOTSUP                => 45;               /* Operation not supported */
            public override int EOPNOTSUPP             => this.ENOTSUP;     /* Operation not supported on socket */
            public override int EPFNOSUPPORT           => 46;               /* Protocol family not supported */
            public override int EAFNOSUPPORT           => 47;               /* Address family not supported by protocol family */
            public override int EADDRINUSE             => 48;               /* Address already in use */
            public override int EADDRNOTAVAIL          => 49;               /* Can't assign requested address */

            /* ipc/network software -- operational errors */
            public override int ENETDOWN               => 50;               /* Network is down */
            public override int ENETUNREACH            => 51;               /* Network is unreachable */
            public override int ENETRESET              => 52;               /* Network dropped connection on reset */
            public override int ECONNABORTED           => 53;               /* Software caused connection abort */
            public override int ECONNRESET             => 54;               /* Connection reset by peer */
            public override int ENOBUFS                => 55;               /* No buffer space available */
            public override int EISCONN                => 56;               /* Socket is already connected */
            public override int ENOTCONN               => 57;               /* Socket is not connected */
            public override int ESHUTDOWN              => 58;               /* Can't send after socket shutdown */
            public override int ETOOMANYREFS           => 59;               /* Too many references: can't splice */
            public override int ETIMEDOUT              => 60;               /* Operation timed out */
            public override int ECONNREFUSED           => 61;               /* Connection refused */

            public override int ELOOP                  => 62;               /* Too many levels of symbolic links */
            public override int ENAMETOOLONG           => 63;               /* File name too long */

            public override int EHOSTDOWN              => 64;               /* Host is down */
            public override int EHOSTUNREACH           => 65;               /* No route to host */
            public override int ENOTEMPTY              => 66;               /* Directory not empty */

            public override int EPROCLIM               => 67;               /* Too many processes */
            public override int EUSERS                 => 68;               /* Too many users */
            public override int EDQUOT                 => 69;               /* Disc quota exceeded */

            /* Network File System */
            public override int ESTALE                 => 70;               /* Stale NFS file handle */
            public override int EREMOTE                => 71;               /* Too many levels of remote in path */
            public override int EBADRPC                => 72;               /* RPC struct is bad */
            public override int ERPCMISMATCH           => 73;               /* RPC version wrong */
            public override int EPROGUNAVAIL           => 74;               /* RPC prog. not avail */
            public override int EPROGMISMATCH          => 75;               /* Program version wrong */
            public override int EPROCUNAVAIL           => 76;               /* Bad procedure for program */

            public override int ENOLCK                 => 77;               /* No locks available */
            public override int ENOSYS                 => 78;               /* Function not implemented */

            public override int EFTYPE                 => 79;               /* Inappropriate file type or format */
            public override int EAUTH                  => 80;               /* Authentication error */
            public override int ENEEDAUTH              => 81;               /* Need authenticator */

            /* Intelligent device errors */
            public override int EPWROFF                => 82;               /* Device power is off */
            public override int EDEVERR                => 83;               /* Device error, e.g. paper out */

            public override int EOVERFLOW              => 84;               /* Value too large to be stored in data type */

            /* Program loading errors */
            public override int EBADEXEC               => 85;               /* Bad executable */
            public override int EBADARCH               => 86;               /* Bad CPU type in executable */
            public override int ESHLIBVERS             => 87;               /* Shared library version mismatch */
            public override int EBADMACHO              => 88;               /* Malformed Macho file */

            public override int ECANCELED              => 89;               /* Operation canceled */

            public override int EIDRM                  => 90;               /* Identifier removed */
            public override int ENOMSG                 => 91;               /* No message of desired type */   
            public override int EILSEQ                 => 92;               /* Illegal byte sequence */
            public override int ENOATTR                => 93;               /* Attribute not found */

            public override int EBADMSG                => 94;               /* Bad message */
            public override int EMULTIHOP              => 95;               /* Reserved */
            public override int ENODATA                => 96;               /* No message available on STREAM */
            public override int ENOLINK                => 97;               /* Reserved */
            public override int ENOSR                  => 98;               /* No STREAM resources */
            public override int ENOSTR                 => 99;               /* Not a STREAM */
            public override int EPROTO                 => 100;              /* Protocol error */
            public override int ETIME                  => 101;              /* STREAM ioctl timeout */

            public override int ENOPOLICY              => 103;              /* No such policy registered */
        }
    }
}
