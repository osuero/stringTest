using Xunit;
namespace Encora.StringTest
{
    public  class BaseTestContext 
    {

        public static TheoryData<string, string> TestCaseData01 => new TheoryData<string, string>
        {
            { "abaccadcc", "ccccaaabd" },
            { "xyzxy", "xxyyz" },
        };
 
        public static TheoryData<string, string> TestCaseData02 => new TheoryData<string, string>
        {
            { "dulgvgzwqg", "gggdlquvwz" },
            { "gxtjtmtywr", "tttgjmrwxy" },
            { "hnlnxiupgt", "nnghilptux" },
            { "gzjotckivp", "cgijkoptvz" },
            { "dpwwsdptae", "ddppwwaest" },
            { "pcscpilknb", "ccppbiklns" },
            { "btvyhhmflf", "ffhhblmtvy" },
            { "artrtnqxcr", "rrrttacnqx" },
            { "nrtcmcoadn", "ccnnadmort" },
            { "fkdsgnekft", "ffkkdegnst" },
        };

        public static  TheoryData<string, string> TestCaseData03 => new TheoryData<string, string>
        {
            { "wzenwebuau", "eeuuwwabnz" },
            { "vokfxzynwl", "fklnovwxyz" },
            { "neldfeyrxk", "eedfklnrxy" },
            { "wqadfiodgs", "ddafgioqsw" },
            { "ykiuvzfcbc", "ccbfikuvyz" },
        };
        public static TheoryData<string, string> TestCaseData04 => new TheoryData<string, string>
        {
            { "qakmc", "ackmq" },
            { "rrtbk", "rrbkt" },
            { "vaixn", "ainvx" },
            { "wmpnj", "jmnpw" },
            { "uproi", "iopru" },
            { "btska", "abkst" },
            { "ejqwr", "ejqrw" },
            { "elwlg", "llegw" },
            { "oaoiy", "ooaiy" },
            { "hrqkn", "hknqr" },
        };

        public static TheoryData<string, string> TestCaseData05 => new TheoryData<string, string>
        {  
            { "pzjim", "ijmpz" },
            { "njnfq", "nnfjq" },
            { "xyohs", "hosxy" },
        };
        public static  TheoryData<string, string> TestCaseData06 => new TheoryData<string, string>
        {
            { "xqycs", "cqsxy" },
            { "beoax", "abeox" },
            { "afkso", "afkos" },
            { "bldit", "bdilt" },
            { "gwrys", "grswy" },
        };

        public static TheoryData<string, string> TestCaseDataNumbers => new TheoryData<string, string>
        {
            { "2", null },
            { "10", null },
            { "5", null },
        };
    }
}
