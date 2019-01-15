namespace Tmds.LibC
{
    public static partial class Definitions
    {
        public static int EPERM => 1;
        public static int ENOENT => 2;
        public static int ESRCH => 3;
        public static int EINTR => 4;
        public static int EIO => 5;
        public static int ENXIO => 6;
        public static int E2BIG => 7;
        public static int ENOEXEC => 8;
        public static int EBADF => 9;
        public static int ECHILD => 10;
        public static int EAGAIN => 11;
        public static int ENOMEM => 12;
        public static int EACCES => 13;
        public static int EFAULT => 14;
        public static int ENOTBLK => 15;
        public static int EBUSY => 16;
        public static int EEXIST => 17;
        public static int EXDEV => 18;
        public static int ENODEV => 19;
        public static int ENOTDIR => 20;
        public static int EISDIR => 21;
        public static int EINVAL => 22;
        public static int ENFILE => 23;
        public static int EMFILE => 24;
        public static int ENOTTY => 25;
        public static int ETXTBSY => 26;
        public static int EFBIG => 27;
        public static int ENOSPC => 28;
        public static int ESPIPE => 29;
        public static int EROFS => 30;
        public static int EMLINK => 31;
        public static int EPIPE => 32;
        public static int EDOM => 33;
        public static int ERANGE => 34;
        public static int EDEADLK => 35;
        public static int ENAMETOOLONG => 36;
        public static int ENOLCK => 37;
        public static int ENOSYS => 38;
        public static int ENOTEMPTY => 39;
        public static int ELOOP => 40;
        public static int EWOULDBLOCK => EAGAIN;
        public static int ENOMSG => 42;
        public static int EIDRM => 43;
        public static int ECHRNG => 44;
        public static int EL2NSYNC => 45;
        public static int EL3HLT => 46;
        public static int EL3RST => 47;
        public static int ELNRNG => 48;
        public static int EUNATCH => 49;
        public static int ENOCSI => 50;
        public static int EL2HLT => 51;
        public static int EBADE => 52;
        public static int EBADR => 53;
        public static int EXFULL => 54;
        public static int ENOANO => 55;
        public static int EBADRQC => 56;
        public static int EBADSLT => 57;
        public static int EDEADLOCK => EDEADLK;
        public static int EBFONT => 59;
        public static int ENOSTR => 60;
        public static int ENODATA => 61;
        public static int ETIME => 62;
        public static int ENOSR => 63;
        public static int ENONET => 64;
        public static int ENOPKG => 65;
        public static int EREMOTE => 66;
        public static int ENOLINK => 67;
        public static int EADV => 68;
        public static int ESRMNT => 69;
        public static int ECOMM => 70;
        public static int EPROTO => 71;
        public static int EMULTIHOP => 72;
        public static int EDOTDOT => 73;
        public static int EBADMSG => 74;
        public static int EOVERFLOW => 75;
        public static int ENOTUNIQ => 76;
        public static int EBADFD => 77;
        public static int EREMCHG => 78;
        public static int ELIBACC => 79;
        public static int ELIBBAD => 80;
        public static int ELIBSCN => 81;
        public static int ELIBMAX => 82;
        public static int ELIBEXEC => 83;
        public static int EILSEQ => 84;
        public static int ERESTART => 85;
        public static int ESTRPIPE => 86;
        public static int EUSERS => 87;
        public static int ENOTSOCK => 88;
        public static int EDESTADDRREQ => 89;
        public static int EMSGSIZE => 90;
        public static int EPROTOTYPE => 91;
        public static int ENOPROTOOPT => 92;
        public static int EPROTONOSUPPORT => 93;
        public static int ESOCKTNOSUPPORT => 94;
        public static int EOPNOTSUPP => 95;
        public static int ENOTSUP => EOPNOTSUPP;
        public static int EPFNOSUPPORT => 96;
        public static int EAFNOSUPPORT => 97;
        public static int EADDRINUSE => 98;
        public static int EADDRNOTAVAIL => 99;
        public static int ENETDOWN => 100;
        public static int ENETUNREACH => 101;
        public static int ENETRESET => 102;
        public static int ECONNABORTED => 103;
        public static int ECONNRESET => 104;
        public static int ENOBUFS => 105;
        public static int EISCONN => 106;
        public static int ENOTCONN => 107;
        public static int ESHUTDOWN => 108;
        public static int ETOOMANYREFS => 109;
        public static int ETIMEDOUT => 110;
        public static int ECONNREFUSED => 111;
        public static int EHOSTDOWN => 112;
        public static int EHOSTUNREACH => 113;
        public static int EALREADY => 114;
        public static int EINPROGRESS => 115;
        public static int ESTALE => 116;
        public static int EUCLEAN => 117;
        public static int ENOTNAM => 118;
        public static int ENAVAIL => 119;
        public static int EISNAM => 120;
        public static int EREMOTEIO => 121;
        public static int EDQUOT => 122;
        public static int ENOMEDIUM => 123;
        public static int EMEDIUMTYPE => 124;
        public static int ECANCELED => 125;
        public static int ENOKEY => 126;
        public static int EKEYEXPIRED => 127;
        public static int EKEYREVOKED => 128;
        public static int EKEYREJECTED => 129;
        public static int EOWNERDEAD => 130;
        public static int ENOTRECOVERABLE => 131;
        public static int ERFKILL => 132;
        public static int EHWPOISON => 133;
    }
}