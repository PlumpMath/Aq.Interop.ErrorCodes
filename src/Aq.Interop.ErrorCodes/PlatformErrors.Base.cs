namespace Aq.Interop {
    partial class PlatformErrors {
        public abstract class Base {
            public virtual int STRUNCATE            => int.MaxValue;
            public virtual int EDEADLOCK            => int.MaxValue;
            public virtual int ENOTRECOVERABLE      => int.MaxValue;
            public virtual int EOTHER               => int.MaxValue;
            public virtual int EOWNERDEAD           => int.MaxValue;

            public virtual int EPERM                => int.MaxValue;
            public virtual int ENOENT               => int.MaxValue;
            public virtual int ESRCH                => int.MaxValue;
            public virtual int EINTR                => int.MaxValue;
            public virtual int EIO                  => int.MaxValue;
            public virtual int ENXIO                => int.MaxValue;
            public virtual int E2BIG                => int.MaxValue;
            public virtual int ENOEXEC              => int.MaxValue;
            public virtual int EBADF                => int.MaxValue;
            public virtual int ECHILD               => int.MaxValue;
            public virtual int EDEADLK              => int.MaxValue;
            public virtual int ENOMEM               => int.MaxValue;
            public virtual int EACCES               => int.MaxValue;
            public virtual int EFAULT               => int.MaxValue;
            public virtual int ENOTBLK              => int.MaxValue;
            public virtual int EBUSY                => int.MaxValue;
            public virtual int EEXIST               => int.MaxValue;
            public virtual int EXDEV                => int.MaxValue;
            public virtual int ENODEV               => int.MaxValue;
            public virtual int ENOTDIR              => int.MaxValue;
            public virtual int EISDIR               => int.MaxValue;
            public virtual int EINVAL               => int.MaxValue;
            public virtual int ENFILE               => int.MaxValue;
            public virtual int EMFILE               => int.MaxValue;
            public virtual int ENOTTY               => int.MaxValue;
            public virtual int ETXTBSY              => int.MaxValue;
            public virtual int EFBIG                => int.MaxValue;
            public virtual int ENOSPC               => int.MaxValue;
            public virtual int ESPIPE               => int.MaxValue;
            public virtual int EROFS                => int.MaxValue;
            public virtual int EMLINK               => int.MaxValue;
            public virtual int EPIPE                => int.MaxValue;

            /* math software */
            public virtual int EDOM                 => int.MaxValue;
            public virtual int ERANGE               => int.MaxValue;

            /* non-blocking and interrupt i/o */
            public virtual int EAGAIN               => int.MaxValue;
            public virtual int EWOULDBLOCK          => int.MaxValue;
            public virtual int EINPROGRESS          => int.MaxValue;
            public virtual int EALREADY             => int.MaxValue;

            /* ipc/network software -- argument errors */
            public virtual int ENOTSOCK             => int.MaxValue;
            public virtual int EDESTADDRREQ         => int.MaxValue;
            public virtual int EMSGSIZE             => int.MaxValue;
            public virtual int EPROTOTYPE           => int.MaxValue;
            public virtual int ENOPROTOOPT          => int.MaxValue;
            public virtual int EPROTONOSUPPORT      => int.MaxValue;
            public virtual int ESOCKTNOSUPPORT      => int.MaxValue;
            public virtual int ENOTSUP              => int.MaxValue;
            public virtual int EOPNOTSUPP           => int.MaxValue;
            public virtual int EPFNOSUPPORT         => int.MaxValue;
            public virtual int EAFNOSUPPORT         => int.MaxValue;
            public virtual int EADDRINUSE           => int.MaxValue;
            public virtual int EADDRNOTAVAIL        => int.MaxValue;

            /* ipc/network software -- operational errors */
            public virtual int ENETDOWN             => int.MaxValue;
            public virtual int ENETUNREACH          => int.MaxValue;
            public virtual int ENETRESET            => int.MaxValue;
            public virtual int ECONNABORTED         => int.MaxValue;
            public virtual int ECONNRESET           => int.MaxValue;
            public virtual int ENOBUFS              => int.MaxValue;
            public virtual int EISCONN              => int.MaxValue;
            public virtual int ENOTCONN             => int.MaxValue;
            public virtual int ESHUTDOWN            => int.MaxValue;
            public virtual int ETOOMANYREFS         => int.MaxValue;
            public virtual int ETIMEDOUT            => int.MaxValue;
            public virtual int ECONNREFUSED         => int.MaxValue;

            public virtual int ELOOP                => int.MaxValue;
            public virtual int ENAMETOOLONG         => int.MaxValue;

            public virtual int EHOSTDOWN            => int.MaxValue;
            public virtual int EHOSTUNREACH         => int.MaxValue;
            public virtual int ENOTEMPTY            => int.MaxValue;

            public virtual int EPROCLIM             => int.MaxValue;
            public virtual int EUSERS               => int.MaxValue;
            public virtual int EDQUOT               => int.MaxValue;

            /* Network File System */
            public virtual int ESTALE               => int.MaxValue;
            public virtual int EREMOTE              => int.MaxValue;
            public virtual int EBADRPC              => int.MaxValue;
            public virtual int ERPCMISMATCH         => int.MaxValue;
            public virtual int EPROGUNAVAIL         => int.MaxValue;
            public virtual int EPROGMISMATCH        => int.MaxValue;
            public virtual int EPROCUNAVAIL         => int.MaxValue;

            public virtual int ENOLCK               => int.MaxValue;
            public virtual int ENOSYS               => int.MaxValue;

            public virtual int EFTYPE               => int.MaxValue;
            public virtual int EAUTH                => int.MaxValue;
            public virtual int ENEEDAUTH            => int.MaxValue;

            /* Intelligent device errors */
            public virtual int EPWROFF              => int.MaxValue;
            public virtual int EDEVERR              => int.MaxValue;

            public virtual int EOVERFLOW            => int.MaxValue;

            /* Program loading errors */
            public virtual int EBADEXEC             => int.MaxValue;
            public virtual int EBADARCH             => int.MaxValue;
            public virtual int ESHLIBVERS           => int.MaxValue;
            public virtual int EBADMACHO            => int.MaxValue;

            public virtual int ECANCELED            => int.MaxValue;

            public virtual int EIDRM                => int.MaxValue;
            public virtual int ENOMSG               => int.MaxValue;
            public virtual int EILSEQ               => int.MaxValue;
            public virtual int ENOATTR              => int.MaxValue;

            public virtual int EBADMSG              => int.MaxValue;
            public virtual int EMULTIHOP            => int.MaxValue;
            public virtual int ENODATA              => int.MaxValue;
            public virtual int ENOLINK              => int.MaxValue;
            public virtual int ENOSR                => int.MaxValue;
            public virtual int ENOSTR               => int.MaxValue;
            public virtual int EPROTO               => int.MaxValue;
            public virtual int ETIME                => int.MaxValue;

            public virtual int ENOPOLICY            => int.MaxValue;
        }
    }
}
