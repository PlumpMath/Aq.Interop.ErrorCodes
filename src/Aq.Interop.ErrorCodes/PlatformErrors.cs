namespace Aq.Interop {
    public static partial class PlatformErrors {
        private static readonly Base Current;

        static PlatformErrors() {
#if CORECLR
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(
                System.Runtime.InteropServices.OSPlatform.Windows)) {
                
                Current = new Win();
            }
            else {
                Current = new Posix();
            }
#else
            switch (System.Environment.OSVersion.Platform) {
                case System.PlatformID.Unix:
                case System.PlatformID.MacOSX:
                    Current = new Posix();
                    break;
                default:
                    Current = new Win();
                    break;
            }
#endif
        }

        public static int STRUNCATE             => Current.STRUNCATE;
        public static int EDEADLOCK             => Current.EDEADLOCK;
        public static int ENOTRECOVERABLE       => Current.ENOTRECOVERABLE;
        public static int EOTHER                => Current.EOTHER;
        public static int EOWNERDEAD            => Current.EOWNERDEAD;

        public static int EPERM                 => Current.EPERM;
        public static int ENOENT                => Current.ENOENT;
        public static int ESRCH                 => Current.ESRCH;
        public static int EINTR                 => Current.EINTR;
        public static int EIO                   => Current.EIO;
        public static int ENXIO                 => Current.ENXIO;
        public static int E2BIG                 => Current.E2BIG;
        public static int ENOEXEC               => Current.ENOEXEC;
        public static int EBADF                 => Current.EBADF;
        public static int ECHILD                => Current.ECHILD;
        public static int EDEADLK               => Current.EDEADLK;
        public static int ENOMEM                => Current.ENOMEM;
        public static int EACCES                => Current.EACCES;
        public static int EFAULT                => Current.EFAULT;
        public static int ENOTBLK               => Current.ENOTBLK;
        public static int EBUSY                 => Current.EBUSY;
        public static int EEXIST                => Current.EEXIST;
        public static int EXDEV                 => Current.EXDEV;
        public static int ENODEV                => Current.ENODEV;
        public static int ENOTDIR               => Current.ENOTDIR;
        public static int EISDIR                => Current.EISDIR;
        public static int EINVAL                => Current.EINVAL;
        public static int ENFILE                => Current.ENFILE;
        public static int EMFILE                => Current.EMFILE;
        public static int ENOTTY                => Current.ENOTTY;
        public static int ETXTBSY               => Current.ETXTBSY;
        public static int EFBIG                 => Current.EFBIG;
        public static int ENOSPC                => Current.ENOSPC;
        public static int ESPIPE                => Current.ESPIPE;
        public static int EROFS                 => Current.EROFS;
        public static int EMLINK                => Current.EMLINK;
        public static int EPIPE                 => Current.EPIPE;

        /* math software */
        public static int EDOM                  => Current.EDOM;
        public static int ERANGE                => Current.ERANGE;

        /* non-blocking and interrupt i/o */
        public static int EAGAIN                => Current.EAGAIN;
        public static int EWOULDBLOCK           => Current.EWOULDBLOCK;
        public static int EINPROGRESS           => Current.EINPROGRESS;
        public static int EALREADY              => Current.EALREADY;

        /* ipc/network software -- argument errors */
        public static int ENOTSOCK              => Current.ENOTSOCK;
        public static int EDESTADDRREQ          => Current.EDESTADDRREQ;
        public static int EMSGSIZE              => Current.EMSGSIZE;
        public static int EPROTOTYPE            => Current.EPROTOTYPE;
        public static int ENOPROTOOPT           => Current.ENOPROTOOPT;
        public static int EPROTONOSUPPORT       => Current.EPROTONOSUPPORT;
        public static int ESOCKTNOSUPPORT       => Current.ESOCKTNOSUPPORT;
        public static int ENOTSUP               => Current.ENOTSUP;
        public static int EOPNOTSUPP            => Current.EOPNOTSUPP;
        public static int EPFNOSUPPORT          => Current.EPFNOSUPPORT;
        public static int EAFNOSUPPORT          => Current.EAFNOSUPPORT;
        public static int EADDRINUSE            => Current.EADDRINUSE;
        public static int EADDRNOTAVAIL         => Current.EADDRNOTAVAIL;

        /* ipc/network software -- operational errors */
        public static int ENETDOWN              => Current.ENETDOWN;
        public static int ENETUNREACH           => Current.ENETUNREACH;
        public static int ENETRESET             => Current.ENETRESET;
        public static int ECONNABORTED          => Current.ECONNABORTED;
        public static int ECONNRESET            => Current.ECONNRESET;
        public static int ENOBUFS               => Current.ENOBUFS;
        public static int EISCONN               => Current.EISCONN;
        public static int ENOTCONN              => Current.ENOTCONN;
        public static int ESHUTDOWN             => Current.ESHUTDOWN;
        public static int ETOOMANYREFS          => Current.ETOOMANYREFS;
        public static int ETIMEDOUT             => Current.ETIMEDOUT;
        public static int ECONNREFUSED          => Current.ECONNREFUSED;

        public static int ELOOP                 => Current.ELOOP;
        public static int ENAMETOOLONG          => Current.ENAMETOOLONG;

        public static int EHOSTDOWN             => Current.EHOSTDOWN;
        public static int EHOSTUNREACH          => Current.EHOSTUNREACH;
        public static int ENOTEMPTY             => Current.ENOTEMPTY;

        public static int EPROCLIM              => Current.EPROCLIM;
        public static int EUSERS                => Current.EUSERS;
        public static int EDQUOT                => Current.EDQUOT;

        /* Network File System */
        public static int ESTALE                => Current.ESTALE;
        public static int EREMOTE               => Current.EREMOTE;
        public static int EBADRPC               => Current.EBADRPC;
        public static int ERPCMISMATCH          => Current.ERPCMISMATCH;
        public static int EPROGUNAVAIL          => Current.EPROGUNAVAIL;
        public static int EPROGMISMATCH         => Current.EPROGMISMATCH;
        public static int EPROCUNAVAIL          => Current.EPROCUNAVAIL;

        public static int ENOLCK                => Current.ENOLCK;
        public static int ENOSYS                => Current.ENOSYS;

        public static int EFTYPE                => Current.EFTYPE;
        public static int EAUTH                 => Current.EAUTH;
        public static int ENEEDAUTH             => Current.ENEEDAUTH;

        /* Intelligent device errors */
        public static int EPWROFF               => Current.EPWROFF;
        public static int EDEVERR               => Current.EDEVERR;

        public static int EOVERFLOW             => Current.EOVERFLOW;

        /* Program loading errors */
        public static int EBADEXEC              => Current.EBADEXEC;
        public static int EBADARCH              => Current.EBADARCH;
        public static int ESHLIBVERS            => Current.ESHLIBVERS;
        public static int EBADMACHO             => Current.EBADMACHO;

        public static int ECANCELED             => Current.ECANCELED;

        public static int EIDRM                 => Current.EIDRM;
        public static int ENOMSG                => Current.ENOMSG;
        public static int EILSEQ                => Current.EILSEQ;
        public static int ENOATTR               => Current.ENOATTR;

        public static int EBADMSG               => Current.EBADMSG;
        public static int EMULTIHOP             => Current.EMULTIHOP;
        public static int ENODATA               => Current.ENODATA;
        public static int ENOLINK               => Current.ENOLINK;
        public static int ENOSR                 => Current.ENOSR;
        public static int ENOSTR                => Current.ENOSTR;
        public static int EPROTO                => Current.EPROTO;
        public static int ETIME                 => Current.ETIME;

        public static int ENOPOLICY             => Current.ENOPOLICY;
    }
}
