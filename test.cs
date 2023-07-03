using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace fit_csm.classes
{
    public class OBJECTX
    {
        public class OBJ
        {
            public class RootX : ICloneable
            {
                public string EXPID { get; set; }
                public string EXPDETAIL { get; set; }
                public GENERAL GENERAL { get; set; }
                public List<TREATMENT> TREATMENTS { get; set; }
                public Dictionary<int, CULTIVAR> CULTIVARS { get; set; }
                public Dictionary<int, FIELD> FIELDS { get; set; }
                public Dictionary<int, SOIL> SOIL { get; set; }
                public Dictionary<int, ICONDITION> ICONDITIONS { get; set; }
                public Dictionary<int, PLANTING> PLANTING { get; set; }
                public Dictionary<int, IRRIGATION> IRRIGATION { get; set; }
                public Dictionary<int, List<FERTILIZER>> FERTILIZERS { get; set; }
                public Dictionary<int, List<RESIDUE>> RESIDUES { get; set; }
                public Dictionary<int, List<CHEMICAL>> CHEMICAL { get; set; }
                public Dictionary<int, List<TILLAGE>> TILLAGE { get; set; }
                public Dictionary<int, List<ENVIRONMENT>> ENVIRONMENT { get; set; }
                public Dictionary<int, List<HARVEST>> HARVEST { get; set; }
                public Dictionary<int, SIMULATION> SIMULATION { get; set; }

                public virtual object Clone()
                {
                    return this.MemberwiseClone();
                }
            }

            public class GENERAL
            {
                public string PEOPLE { get; set; }
                public string ADDRESS { get; set; }
                public string SITE { get; set; }
                public string PAREA { get; set; }
                public string PRNO { get; set; }
                public string PLEN { get; set; }
                public string PLDR { get; set; }
                public string PLSP { get; set; }
                public string PLAY { get; set; }
                public string HAREA { get; set; }
                public string HRNO { get; set; }
                public string HLEN { get; set; }
                public string HARM { get; set; }
                public string NOTES { get; set; }
            }

            public class TREATMENT
            {
                public int N { get; set; }
                public int R { get; set; }
                public int O { get; set; }
                public int C { get; set; }
                public string TNAME { get; set; }
                public int CU { get; set; }
                public int FL { get; set; }
                public int SA { get; set; }
                public int IC { get; set; }
                public int MP { get; set; }
                public int MI { get; set; }
                public int MF { get; set; }
                public int MR { get; set; }
                public int MC { get; set; }
                public int MT { get; set; }
                public int ME { get; set; }
                public int MH { get; set; }
                public int SM { get; set; }
            }

            public class CULTIVAR
            {
                public int C { get; set; }
                public string CR { get; set; }
                public string INGENO { get; set; }
                public string CNAME { get; set; }
            }

            public class FIELD
            {
                public int L { get; set; }
                public FIELD0 FIELD_0 { get; set; }
                public FIELD1 FIELD_1 { get; set; }
            }

            public class FIELD0
            {
                public string ID_FIELD { get; set; }
                public string WSTA { get; set; }
                public string FLSA { get; set; }
                public string FLOB { get; set; }
                public string FLDT { get; set; }
                public string FLDD { get; set; }
                public string FLDS { get; set; }
                public string FLST { get; set; }
                public string SLTX { get; set; }
                public string SLDP { get; set; }
                public string ID_SOIL { get; set; }
                public string FLNAME { get; set; }
            }

            public class FIELD1
            {
                public string XCRD { get; set; }
                public string YCRD { get; set; }
                public string ELEV { get; set; }
                public string AREA { get; set; }
                public string SLEN { get; set; }
                public string FLWR { get; set; }
                public string SLAS { get; set; }
                public string FLHST { get; set; }
                public string FHDUR { get; set; }
            }

            public class SOIL
            {
                public int A { get; set; }
                public SOIL0 SOIL_0 { get; set; }
                public List<SOIL1> SOIL_1 { get; set; }
            }

            public class SOIL0
            {
                public string SADAT { get; set; }
                public string SMHB { get; set; }
                public string SMPX { get; set; }
                public string SMKE { get; set; }
                public string SANAME { get; set; }
            }

            public class SOIL1
            {
                public string SABL { get; set; }
                public string SADM { get; set; }
                public string SAOC { get; set; }
                public string SANI { get; set; }
                public string SAPHW { get; set; }
                public string SAPHB { get; set; }
                public string SAPX { get; set; }
                public string SAKE { get; set; }
                public string SASC { get; set; }
            }

            public class ICONDITION
            {
                public int C { get; set; }
                public ICONDITION0 ICONDITION_0 { get; set; }
                public List<ICONDITION1> ICONDITION_1 { get; set; }
            }

            public class ICONDITION0
            {
                public string PCR { get; set; }
                public string ICDAT { get; set; }
                public string ICRT { get; set; }
                public string ICND { get; set; }
                public string ICRN { get; set; }
                public string ICRE { get; set; }
                public string ICWD { get; set; }
                public string ICRES { get; set; }
                public string ICREN { get; set; }
                public string ICREP { get; set; }
                public string ICRIP { get; set; }
                public string ICRID { get; set; }
                public string ICNAME { get; set; }
            }

            public class ICONDITION1
            {
                public string ICBL { get; set; }
                public string SH2O { get; set; }
                public string SNH4 { get; set; }
                public string SNO3 { get; set; }
            }

            public class PLANTING
            {
                public int P { get; set; }
                public string PDATE { get; set; }
                public string EDATE { get; set; }
                public string PPOP { get; set; }
                public string PPOE { get; set; }
                public string PLME { get; set; }
                public string PLDS { get; set; }
                public string PLRS { get; set; }
                public string PLRD { get; set; }
                public string PLDP { get; set; }
                public string PLWT { get; set; }
                public string PAGE { get; set; }
                public string PENV { get; set; }
                public string PLPH { get; set; }
                public string SPRL { get; set; }
                public string PLNAME { get; set; }
            }

            public class IRRIGATION
            {
                public int I { get; set; }
                public IRRIGATION0 IRRIGATION_0 { get; set; }
                public List<IRRIGATION1> IRRIGATION_1 { get; set; }
            }

            public class IRRIGATION0
            {
                public string EFIR { get; set; }
                public string IDEP { get; set; }
                public string ITHR { get; set; }
                public string IEPT { get; set; }
                public string IOFF { get; set; }
                public string IAME { get; set; }
                public string IAMT { get; set; }
                public string IRNAME { get; set; }
            }

            public class IRRIGATION1
            {
                public string IDATE { get; set; }
                public string IROP { get; set; }
                public string IRVAL { get; set; }
            }

            public class FERTILIZER
            {
                public int F { get; set; }
                public string FDATE { get; set; }
                public string FMCD { get; set; }
                public string FACD { get; set; }
                public string FDEP { get; set; }
                public string FAMN { get; set; }
                public string FAMP { get; set; }
                public string FAMK { get; set; }
                public string FAMC { get; set; }
                public string FAMO { get; set; }
                public string FOCD { get; set; }
                public string FERNAME { get; set; }
            }

            public class RESIDUE
            {
                public int R { get; set; }
                public string RDATE { get; set; }
                public string RCOD { get; set; }
                public string RAMT { get; set; }
                public string RESN { get; set; }
                public string RESP { get; set; }
                public string RESK { get; set; }
                public string RINP { get; set; }
                public string RDEP { get; set; }
                public string RMET { get; set; }
                public string RENAME { get; set; }
            }

            public class CHEMICAL
            {
                public int C { get; set; }
                public string CDATE { get; set; }
                public string CHCOD { get; set; }
                public string CHAMT { get; set; }
                public string CHME { get; set; }
                public string CHDEP { get; set; }
                public string CHT { get; set; }
                public string CHNAME { get; set; }
            }

            public class TILLAGE
            {
                public int T { get; set; }
                public string TDATE { get; set; }
                public string TIMPL { get; set; }
                public string TDEP { get; set; }
                public string TNAME { get; set; }
            }

            public class ENVIRONMENT
            {
                public int E { get; set; }
                public string ODATE { get; set; }
                public string MEDAY { get; set; }
                public string EDAY { get; set; }
                public string MERAD { get; set; }
                public string ERAD { get; set; }
                public string MEMAX { get; set; }
                public string EMAX { get; set; }
                public string MEMIN { get; set; }
                public string EMIN { get; set; }
                public string MERAIN { get; set; }
                public string ERAIN { get; set; }
                public string MECO2 { get; set; }
                public string ECO2 { get; set; }
                public string MEDEW { get; set; }
                public string EDEW { get; set; }
                public string MEWIND { get; set; }
                public string EWIND { get; set; }
                public string ENVNAME { get; set; }
            }

            public class HARVEST
            {
                public int H { get; set; }
                public string HDATE { get; set; }
                public string HSTG { get; set; }
                public string HCOM { get; set; }
                public string HSIZE { get; set; }
                public string HPC { get; set; }
                public string HBPC { get; set; }
                public string HNAME { get; set; }
            }

            public class SIMULATION
            {
                public int N { get; set; }
                public SIM SIM { get; set; }
                public AUTO AUTO { get; set; }
            }

            public class SIM
            {
                public GE GE { get; set; }
                public OP OP { get; set; }
                public ME ME { get; set; }
                public MA MA { get; set; }
                public OU OU { get; set; }
            }

            public class GE
            {
                public string NYERS { get; set; }
                public string NREPS { get; set; }
                public string START { get; set; }
                public string SDATE { get; set; }
                public string RSEED { get; set; }
                public string SNAME { get; set; }
                public string SMODEL { get; set; }
            }

            public class OP
            {
                public string WATER { get; set; }
                public string NITRO { get; set; }
                public string SYMBI { get; set; }
                public string PHOSP { get; set; }
                public string POTAS { get; set; }
                public string DISES { get; set; }
                public string CHEM { get; set; }
                public string TILL { get; set; }
                public string CO2 { get; set; }
            }

            public class ME
            {
                public string WTHER { get; set; }
                public string INCON { get; set; }
                public string LIGHT { get; set; }
                public string EVAPO { get; set; }
                public string INFIL { get; set; }
                public string PHOTO { get; set; }
                public string HYDRO { get; set; }
                public string NSWIT { get; set; }
                public string MESOM { get; set; }
                public string MESEV { get; set; }
                public string MESOL { get; set; }
            }

            public class MA
            {
                public string PLANT { get; set; }
                public string IRRIG { get; set; }
                public string FERTI { get; set; }
                public string RESID { get; set; }
                public string HARVS { get; set; }
            }

            public class OU
            {
                public string FNAME { get; set; }
                public string OVVEW { get; set; }
                public string SUMRY { get; set; }
                public string FROPT { get; set; }
                public string GROUT { get; set; }
                public string CAOUT { get; set; }
                public string WAOUT { get; set; }
                public string NIOUT { get; set; }
                public string MIOUT { get; set; }
                public string DIOUT { get; set; }
                public string VBOSE { get; set; }
                public string CHOUT { get; set; }
                public string OPOUT { get; set; }
            }

            public class AUTO
            {
                public PL PL { get; set; }
                public IR IR { get; set; }
                public NI NI { get; set; }
                public RE RE { get; set; }
                public HA HA { get; set; }
            }

            public class PL
            {
                public string PFRST { get; set; }
                public string PLAST { get; set; }
                public string PH2OL { get; set; }
                public string PH2OU { get; set; }
                public string PH2OD { get; set; }
                public string PSTMX { get; set; }
                public string PSTMN { get; set; }
            }

            public class IR
            {
                public string IMDEP { get; set; }
                public string ITHRL { get; set; }
                public string ITHRU { get; set; }
                public string IROFF { get; set; }
                public string IMETH { get; set; }
                public string IRAMT { get; set; }
                public string IREFF { get; set; }
            }

            public class NI
            {
                public string NMDEP { get; set; }
                public string NMTHR { get; set; }
                public string NAMNT { get; set; }
                public string NCODE { get; set; }
                public string NAOFF { get; set; }
            }

            public class RE
            {
                public string RIPCN { get; set; }
                public string RTIME { get; set; }
                public string RIDEP { get; set; }
            }

            public class HA
            {
                public string HFRST { get; set; }
                public string HLAST { get; set; }
                public string HPCNP { get; set; }
                public string HPCNR { get; set; }
            }
        }

        public class UTIL
        {
            public static string SpaceLeft(string str, int len)
            {
                string outString = string.Empty;
                if (!string.IsNullOrEmpty(str))
                {
                    if (str.Length < len)
                    {
                        string o = string.Empty;
                        for (int i = 0; i < len - str.Length; i++) { o += " "; }
                        outString = o + str;
                    }
                    else
                    {
                        outString = " " + str.Substring(0, len - 1);
                    }
                }
                else
                {
                    outString = "ERROR";
                }
                return outString;
            }

            public static string SpaceLeft1(string str, int len)
            {
                string outString = string.Empty;
                if (!string.IsNullOrEmpty(str))
                {
                    if (str.Length < len)
                    {
                        string o = string.Empty;
                        for (int i = 1; i < len - str.Length; i++) { o += " "; }
                        outString = o + str;
                    }
                    else
                    {
                        outString = " " + str.Substring(0, len - 2);
                    }
                }
                else
                {
                    outString = "ERROR";
                }
                return outString;
            }

            public static string SpaceRight(string str, int len)
            {
                string outString = string.Empty;
                if (!string.IsNullOrEmpty(str))
                {
                    if (str.Length < len)
                    {
                        string o = string.Empty;
                        for (int i = 0; i < len - 1 - str.Length; i++) { o += " "; }
                        outString = " " + str + o;
                    }
                    else
                    {
                        outString = " " + str.Substring(0, len - 1);
                    }
                }
                else
                {
                    outString = "ERROR";
                }

                return outString;
            }

            public static DateTime DSSATDate2Datetime(string dssatDate)
            {
                int iYear = int.Parse("20" + dssatDate.Substring(0, 2));
                int dayOfYear = int.Parse(dssatDate.Substring(2, 3));
                return new DateTime(iYear, 1, 1).AddDays(dayOfYear - 1);
            }

            public static string DateTime2DSSATDate(DateTime dd)
            {
                string sYear = dd.Year.ToString().Substring(2, 2);
                int sDOY = dd.DayOfYear;
                if (sDOY < 10) { return string.Concat(sYear, "00", sDOY.ToString()); }
                else if (sDOY < 100) { return string.Concat(sYear, "0", sDOY.ToString()); }
                else { return string.Concat(sYear, sDOY.ToString()); }
            }
        }

        public class WRITE
        {
            public static void writeGENERAL(StreamWriter writer, OBJ.RootX rootX)
            {
                writer.WriteLine("*EXP.DETAILS: " + rootX.EXPDETAIL);
                writer.WriteLine("");
                writer.WriteLine("*GENERAL");
                writer.WriteLine("@PEOPLE");
                writer.WriteLine(rootX.GENERAL.PEOPLE);
                writer.WriteLine("@ADDRESS");
                writer.WriteLine(rootX.GENERAL.ADDRESS);
                writer.WriteLine("@SITE");
                writer.WriteLine(rootX.GENERAL.SITE);
                writer.WriteLine("@ PAREA  PRNO  PLEN  PLDR  PLSP  PLAY HAREA  HRNO  HLEN  HARM.........");
                writer.WriteLine(string.Concat(
                    " ",
                    UTIL.SpaceLeft(rootX.GENERAL.PAREA, 6),
                    UTIL.SpaceLeft(rootX.GENERAL.PRNO, 6),
                    UTIL.SpaceLeft(rootX.GENERAL.PLEN, 6),
                    UTIL.SpaceLeft(rootX.GENERAL.PLDR, 6),
                    UTIL.SpaceLeft(rootX.GENERAL.PLSP, 6),
                    UTIL.SpaceLeft(rootX.GENERAL.PLAY, 6),
                    UTIL.SpaceLeft(rootX.GENERAL.HAREA, 6),
                    UTIL.SpaceLeft(rootX.GENERAL.HRNO, 6),
                    UTIL.SpaceLeft(rootX.GENERAL.HLEN, 6),
                    UTIL.SpaceRight(rootX.GENERAL.HARM, rootX.GENERAL.HARM.Length + 1)
                ));
                writer.WriteLine("@NOTES");
                writer.WriteLine(rootX.GENERAL.NOTES);
                writer.WriteLine("");
            }

            public static void writeTREATMENTS(StreamWriter writer, OBJ.RootX rootX)
            {
                writer.WriteLine("*TREATMENTS                        -------------FACTOR LEVELS------------");
                writer.WriteLine("@N R O C TNAME.................... CU FL SA IC MP MI MF MR MC MT ME MH SM");
                foreach (OBJ.TREATMENT i in rootX.TREATMENTS)
                {
                    string n = i.N < 10 ? " " + i.N.ToString() : i.N.ToString();
                    writer.WriteLine(string.Concat(
                        (i.N < 10 ? " " + i.N.ToString() : i.N.ToString()),
                        (i.R < 10 ? " " + i.R.ToString() : i.R.ToString()),
                        (i.O < 10 ? " " + i.O.ToString() : i.O.ToString()),
                        (i.C < 10 ? " " + i.C.ToString() : i.C.ToString()),
                        (UTIL.SpaceRight(i.TNAME, 26)),
                        (i.CU < 10 ? "  " + i.CU.ToString() : " " + i.CU.ToString()),
                        (i.FL < 10 ? "  " + i.FL.ToString() : " " + i.FL.ToString()),
                        (i.SA < 10 ? "  " + i.SA.ToString() : " " + i.SA.ToString()),
                        (i.IC < 10 ? "  " + i.IC.ToString() : " " + i.IC.ToString()),
                        (i.MP < 10 ? "  " + i.MP.ToString() : " " + i.MP.ToString()),
                        (i.MI < 10 ? "  " + i.MI.ToString() : " " + i.MI.ToString()),
                        (i.MF < 10 ? "  " + i.MF.ToString() : " " + i.MF.ToString()),
                        (i.MR < 10 ? "  " + i.MR.ToString() : " " + i.MR.ToString()),
                        (i.MC < 10 ? "  " + i.MC.ToString() : " " + i.MC.ToString()),
                        (i.MT < 10 ? "  " + i.MT.ToString() : " " + i.MT.ToString()),
                        (i.ME < 10 ? "  " + i.ME.ToString() : " " + i.ME.ToString()),
                        (i.MH < 10 ? "  " + i.MH.ToString() : " " + i.MH.ToString()),
                        (i.SM < 10 ? "  " + i.SM.ToString() : " " + i.SM.ToString())
                    ));
                }
                writer.WriteLine("");
            }

            public static void writeCU(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*CULTIVARS");
                    writer.WriteLine("@C CR INGENO CNAME");
                    foreach (int i in lst)
                    {
                        OBJ.CULTIVAR x = rootX.CULTIVARS[i];
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            (UTIL.SpaceLeft(x.CR, 3)),
                            (UTIL.SpaceLeft(x.INGENO, 7)),
                            (UTIL.SpaceRight(x.CNAME, x.CNAME.Length + 1))
                        ));
                    }
                    writer.WriteLine("");
                }
            }

            public static void writeFL(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*FIELDS");
                    writer.WriteLine("@L ID_FIELD WSTA....  FLSA  FLOB  FLDT  FLDD  FLDS  FLST SLTX  SLDP  ID_SOIL    FLNAME");
                    foreach (int i in lst)
                    {
                        OBJ.FIELD0 x = rootX.FIELDS[i].FIELD_0;
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            (UTIL.SpaceRight(x.ID_FIELD, 9)),
                            (UTIL.SpaceRight(x.WSTA, 9)),
                            (UTIL.SpaceLeft(x.FLSA, 6)),
                            (UTIL.SpaceLeft(x.FLOB, 6)),
                            (UTIL.SpaceLeft(x.FLDT, 6)),
                            (UTIL.SpaceLeft(x.FLDD, 6)),
                            (UTIL.SpaceLeft(x.FLDS, 6)),
                            (UTIL.SpaceLeft(x.FLST, 6)),
                            (UTIL.SpaceRight(x.SLTX, 5)),
                            (UTIL.SpaceLeft(x.SLDP, 6)),
                            (UTIL.SpaceRight(" " + x.ID_SOIL, 12)),
                            (UTIL.SpaceRight(x.FLNAME, x.FLNAME.Length + 1))
                        ));
                    }
                    writer.WriteLine("@L ...........XCRD ...........YCRD .....ELEV .............AREA .SLEN .FLWR .SLAS FLHST FHDUR");
                    foreach (int i in lst)
                    {
                        OBJ.FIELD1 x = rootX.FIELDS[i].FIELD_1;
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            (UTIL.SpaceLeft(x.XCRD, 16)),
                            (UTIL.SpaceLeft(x.YCRD, 16)),
                            (UTIL.SpaceLeft(x.ELEV, 10)),
                            (UTIL.SpaceLeft(x.AREA, 18)),
                            (UTIL.SpaceLeft(x.SLEN, 6)),
                            (UTIL.SpaceLeft(x.FLWR, 6)),
                            (UTIL.SpaceLeft(x.SLAS, 6)),
                            (UTIL.SpaceLeft(x.FLHST, 6)),
                            (UTIL.SpaceLeft(x.FHDUR, 6))
                        ));
                    }
                    writer.WriteLine("");
                }
            }

            public static void writeSA(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*SOIL ANALYSIS");
                    foreach (int i in lst)
                    {
                        OBJ.SOIL0 x0 = rootX.SOIL[i].SOIL_0;
                        List<OBJ.SOIL1> x1 = rootX.SOIL[i].SOIL_1.OrderBy(p => p.SABL).ToList();

                        writer.WriteLine("@A SADAT  SMHB  SMPX  SMKE  SANAME");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            (UTIL.SpaceLeft(x0.SADAT, 6)),
                            (UTIL.SpaceLeft(x0.SMHB, 6)),
                            (UTIL.SpaceLeft(x0.SMPX, 6)),
                            (UTIL.SpaceLeft(x0.SMKE, 6)),
                            (UTIL.SpaceRight(" " + x0.SANAME, x0.SANAME.Length + 2))
                        ));
                        writer.WriteLine("@A  SABL  SADM  SAOC  SANI SAPHW SAPHB  SAPX  SAKE  SASC");
                        foreach (OBJ.SOIL1 j in x1)
                        {
                            writer.WriteLine(string.Concat(
                                ((i < 10 ? " " + i.ToString() : i.ToString())),
                                (UTIL.SpaceLeft(j.SABL, 6)),
                                (UTIL.SpaceLeft(j.SADM, 6)),
                                (UTIL.SpaceLeft(j.SAOC, 6)),
                                (UTIL.SpaceLeft(j.SANI, 6)),
                                (UTIL.SpaceLeft(j.SAPHW, 6)),
                                (UTIL.SpaceLeft(j.SAPHB, 6)),
                                (UTIL.SpaceLeft(j.SAPX, 6)),
                                (UTIL.SpaceLeft(j.SAKE, 6)),
                                (UTIL.SpaceLeft(j.SASC, 6))
                            ));
                        }
                    }
                    writer.WriteLine();
                }
            }

            public static void writeIC(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*INITIAL CONDITIONS");
                    foreach (int i in lst)
                    {
                        OBJ.ICONDITION0 x0 = rootX.ICONDITIONS[i].ICONDITION_0;
                        List<OBJ.ICONDITION1> x1 = rootX.ICONDITIONS[i].ICONDITION_1.OrderBy(s => s.ICBL).ToList();
                        writer.WriteLine("@C   PCR ICDAT  ICRT  ICND  ICRN  ICRE  ICWD ICRES ICREN ICREP ICRIP ICRID ICNAME");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            (UTIL.SpaceLeft(x0.PCR, 6)),
                            (UTIL.SpaceLeft(x0.ICDAT, 6)),
                            (UTIL.SpaceLeft(x0.ICRT, 6)),
                            (UTIL.SpaceLeft(x0.ICND, 6)),
                            (UTIL.SpaceLeft(x0.ICRN, 6)),
                            (UTIL.SpaceLeft(x0.ICRE, 6)),
                            (UTIL.SpaceLeft(x0.ICWD, 6)),
                            (UTIL.SpaceLeft(x0.ICRES, 6)),
                            (UTIL.SpaceLeft(x0.ICREN, 6)),
                            (UTIL.SpaceLeft(x0.ICREP, 6)),
                            (UTIL.SpaceLeft(x0.ICRIP, 6)),
                            (UTIL.SpaceLeft(x0.ICRID, 6)),
                            (UTIL.SpaceRight(x0.ICNAME, x0.ICNAME.Length + 1))
                        ));
                        writer.WriteLine("@C  ICBL  SH2O  SNH4  SNO3");
                        foreach (OBJ.ICONDITION1 j in x1)
                        {
                            writer.WriteLine(string.Concat(
                                ((i < 10 ? " " + i.ToString() : i.ToString())),
                                (UTIL.SpaceLeft(j.ICBL, 6)),
                                (UTIL.SpaceLeft(j.SH2O, 6)),
                                (UTIL.SpaceLeft(j.SNH4, 6)),
                                (UTIL.SpaceLeft(j.SNO3, 6))
                            ));
                        }
                    }
                    writer.WriteLine();
                }
            }

            public static void writeMP(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*PLANTING DETAILS");
                    writer.WriteLine("@P PDATE EDATE  PPOP  PPOE  PLME  PLDS  PLRS  PLRD  PLDP  PLWT  PAGE  PENV  PLPH  SPRL                        PLNAME");
                    foreach (int i in lst)
                    {
                        OBJ.PLANTING x = rootX.PLANTING[i];
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            (UTIL.SpaceLeft(x.PDATE, 6)),
                            (UTIL.SpaceLeft(x.EDATE, 6)),
                            (UTIL.SpaceLeft(x.PPOP, 6)),
                            (UTIL.SpaceLeft(x.PPOE, 6)),
                            (UTIL.SpaceLeft(x.PLME, 6)),
                            (UTIL.SpaceLeft(x.PLDS, 6)),
                            (UTIL.SpaceLeft(x.PLRS, 6)),
                            (UTIL.SpaceLeft(x.PLRD, 6)),
                            (UTIL.SpaceLeft(x.PLDP, 6)),
                            (UTIL.SpaceLeft(x.PLWT, 6)),
                            (UTIL.SpaceLeft(x.PAGE, 6)),
                            (UTIL.SpaceLeft(x.PENV, 6)),
                            (UTIL.SpaceLeft(x.PLPH, 6)),
                            (UTIL.SpaceLeft(x.SPRL, 6)),
                            (UTIL.SpaceRight("                        " + x.PLNAME, x.PLNAME.Length + 26))
                            ));
                    }
                    writer.WriteLine();
                }
            }

            public static void writeMI(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*IRRIGATION AND WATER MANAGEMENT");
                    foreach (int i in lst)
                    {
                        OBJ.IRRIGATION0 x0 = rootX.IRRIGATION[i].IRRIGATION_0;
                        List<OBJ.IRRIGATION1> x1 = rootX.IRRIGATION[i].IRRIGATION_1.OrderBy(s => s.IDATE).ToList();
                        writer.WriteLine("@I  EFIR  IDEP  ITHR  IEPT  IOFF  IAME  IAMT IRNAME");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            (UTIL.SpaceLeft(x0.EFIR, 6)),
                            (UTIL.SpaceLeft(x0.IDEP, 6)),
                            (UTIL.SpaceLeft(x0.ITHR, 6)),
                            (UTIL.SpaceLeft(x0.IEPT, 6)),
                            (UTIL.SpaceLeft(x0.IOFF, 6)),
                            (UTIL.SpaceLeft(x0.IAME, 6)),
                            (UTIL.SpaceLeft(x0.IAMT, 6)),
                            (UTIL.SpaceRight(x0.IRNAME, x0.IRNAME.Length + 1))
                        ));
                        writer.WriteLine("@I IDATE  IROP IRVAL");
                        foreach (OBJ.IRRIGATION1 j in x1)
                        {
                            writer.WriteLine(string.Concat(
                                ((i < 10 ? " " + i.ToString() : i.ToString())),
                                (UTIL.SpaceLeft(j.IDATE, 6)),
                                (UTIL.SpaceLeft(j.IROP, 6)),
                                (UTIL.SpaceLeft(j.IRVAL, 6))
                            ));
                        }
                    }
                    writer.WriteLine("");
                }
            }

            public static void writeMF(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*FERTILIZERS (INORGANIC)");
                    writer.WriteLine("@F FDATE  FMCD  FACD  FDEP  FAMN  FAMP  FAMK  FAMC  FAMO  FOCD FERNAME");
                    foreach (int i in lst)
                    {
                        List<OBJ.FERTILIZER> x = rootX.FERTILIZERS[i].OrderBy(s => s.FDATE).ToList();
                        foreach (OBJ.FERTILIZER j in x)
                        {
                            writer.WriteLine(string.Concat(
                                ((i < 10 ? " " + i.ToString() : i.ToString())),
                                (UTIL.SpaceLeft(j.FDATE, 6)),
                                (UTIL.SpaceLeft(j.FMCD, 6)),
                                (UTIL.SpaceLeft(j.FACD, 6)),
                                (UTIL.SpaceLeft(j.FDEP, 6)),
                                (UTIL.SpaceLeft(j.FAMN, 6)),
                                (UTIL.SpaceLeft(j.FAMP, 6)),
                                (UTIL.SpaceLeft(j.FAMK, 6)),
                                (UTIL.SpaceLeft(j.FAMC, 6)),
                                (UTIL.SpaceLeft(j.FAMO, 6)),
                                (UTIL.SpaceLeft(j.FOCD, 6)),
                                (UTIL.SpaceRight(j.FERNAME, j.FERNAME.Length + 1))
                            ));
                        }
                    }
                    writer.WriteLine("");
                }
            }

            public static void writeMR(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*RESIDUES AND ORGANIC FERTILIZER");
                    writer.WriteLine("@R RDATE  RCOD  RAMT  RESN  RESP  RESK  RINP  RDEP  RMET RENAME");
                    foreach (int i in lst)
                    {
                        List<OBJ.RESIDUE> x = rootX.RESIDUES[i].OrderBy(s => s.RDATE).ToList();
                        foreach (OBJ.RESIDUE j in x)
                        {
                            writer.WriteLine(string.Concat(
                                ((i < 10 ? " " + i.ToString() : i.ToString())),
                                (UTIL.SpaceLeft(j.RDATE, 6)),
                                (UTIL.SpaceLeft(j.RCOD, 6)),
                                (UTIL.SpaceLeft(j.RAMT, 6)),
                                (UTIL.SpaceLeft(j.RESN, 6)),
                                (UTIL.SpaceLeft(j.RESP, 6)),
                                (UTIL.SpaceLeft(j.RESK, 6)),
                                (UTIL.SpaceLeft(j.RINP, 6)),
                                (UTIL.SpaceLeft(j.RDEP, 6)),
                                (UTIL.SpaceLeft(j.RMET, 6)),
                                (UTIL.SpaceRight(j.RENAME, j.RENAME.Length + 1))
                            ));
                        }
                    }
                    writer.WriteLine("");
                }
            }

            public static void writeMC(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*CHEMICAL APPLICATIONS");
                    writer.WriteLine("@C CDATE CHCOD CHAMT  CHME CHDEP   CHT..CHNAME");
                    foreach (int i in lst)
                    {
                        List<OBJ.CHEMICAL> x = rootX.CHEMICAL[i].OrderBy(s => s.CDATE).ToList();
                        foreach (OBJ.CHEMICAL j in x)
                        {
                            writer.WriteLine(string.Concat(
                                ((i < 10 ? " " + i.ToString() : i.ToString())),
                                (UTIL.SpaceLeft(j.CDATE, 6)),
                                (UTIL.SpaceLeft(j.CHCOD, 6)),
                                (UTIL.SpaceLeft(j.CHAMT, 6)),
                                (UTIL.SpaceLeft(j.CHME, 6)),
                                (UTIL.SpaceLeft(j.CHDEP, 6)),
                                (UTIL.SpaceLeft(j.CHT, 6)),
                                (UTIL.SpaceRight(j.CHNAME, j.CHNAME.Length + 1))
                            ));
                        }
                    }
                    writer.WriteLine("");
                }
            }

            public static void writeMT(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*TILLAGE AND ROTATIONS");
                    writer.WriteLine("@T TDATE TIMPL  TDEP TNAME");
                    foreach (int i in lst)
                    {
                        List<OBJ.TILLAGE> x = rootX.TILLAGE[i].OrderBy(s => s.TDATE).ToList();
                        foreach (OBJ.TILLAGE j in x)
                        {
                            writer.WriteLine(string.Concat(
                                ((i < 10 ? " " + i.ToString() : i.ToString())),
                                (UTIL.SpaceLeft(j.TDATE, 6)),
                                (UTIL.SpaceLeft(j.TIMPL, 6)),
                                (UTIL.SpaceLeft(j.TDEP, 6)),
                                (UTIL.SpaceRight(j.TNAME, j.TNAME.Length + 1))
                            ));
                        }
                    }
                    writer.WriteLine("");
                }
            }

            public static void writeME(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*ENVIRONMENT MODIFICATIONS");
                    writer.WriteLine("@E ODATE EDAY  ERAD  EMAX  EMIN  ERAIN ECO2  EDEW  EWIND ENVNAME  ");
                    foreach (int i in lst)
                    {
                        List<OBJ.ENVIRONMENT> x = rootX.ENVIRONMENT[i].OrderBy(s => s.ODATE).ToList();
                        foreach (OBJ.ENVIRONMENT j in x)
                        {
                            writer.WriteLine(string.Concat(
                                ((i < 10 ? " " + i.ToString() : i.ToString())),
                                (UTIL.SpaceLeft(j.ODATE, 6)),
                                (j.MEDAY + UTIL.SpaceLeft1(j.EDAY, 4)),
                                (j.MERAD + UTIL.SpaceLeft1(j.ERAD, 4)),
                                (j.MEMAX + UTIL.SpaceLeft1(j.EMAX, 4)),
                                (j.MEMIN + UTIL.SpaceLeft1(j.EMIN, 4)),
                                (j.MERAIN + UTIL.SpaceLeft1(j.ERAIN, 4)),
                                (j.MECO2 + UTIL.SpaceLeft1(j.ECO2, 4)),
                                (j.MEDEW + UTIL.SpaceLeft1(j.EDEW, 4)),
                                (j.MEWIND + UTIL.SpaceLeft1(j.EWIND, 4)),
                                (UTIL.SpaceRight(j.ENVNAME, j.ENVNAME.Length + 1))
                            ));
                        }
                    }
                    writer.WriteLine("");
                }
            }

            public static void writeMH(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*HARVEST DETAILS");
                    writer.WriteLine("@H HDATE  HSTG  HCOM HSIZE   HPC  HBPC HNAME");
                    foreach (int i in lst)
                    {
                        List<OBJ.HARVEST> x = rootX.HARVEST[i].OrderBy(s => s.HDATE).ToList();
                        foreach (OBJ.HARVEST j in x)
                        {
                            writer.WriteLine(string.Concat(
                                ((i < 10 ? " " + i.ToString() : i.ToString())),
                                (UTIL.SpaceLeft(j.HDATE, 6)),
                                (UTIL.SpaceLeft(j.HSTG, 6)),
                                (UTIL.SpaceLeft(j.HCOM, 6)),
                                (UTIL.SpaceLeft(j.HSIZE, 6)),
                                (UTIL.SpaceLeft(j.HPC, 6)),
                                (UTIL.SpaceLeft(j.HBPC, 6)),
                                (UTIL.SpaceRight(j.HNAME, j.HNAME.Length + 1))
                            ));
                        }
                    }
                    writer.WriteLine("");
                }
            }

            public static void writeSM(StreamWriter writer, OBJ.RootX rootX, List<int> lst)
            {
                lst.Sort();
                if (lst.Count > 0 && !(lst.Count == 1 && lst[0] == 0))
                {
                    writer.WriteLine("*SIMULATION CONTROLS");
                    foreach (int i in lst)
                    {
                        OBJ.GE ge = rootX.SIMULATION[i].SIM.GE;
                        OBJ.OP op = rootX.SIMULATION[i].SIM.OP;
                        OBJ.ME me = rootX.SIMULATION[i].SIM.ME;
                        OBJ.MA ma = rootX.SIMULATION[i].SIM.MA;
                        OBJ.OU ou = rootX.SIMULATION[i].SIM.OU;
                        OBJ.PL pl = rootX.SIMULATION[i].AUTO.PL;
                        OBJ.IR ir = rootX.SIMULATION[i].AUTO.IR;
                        OBJ.NI ni = rootX.SIMULATION[i].AUTO.NI;
                        OBJ.RE re = rootX.SIMULATION[i].AUTO.RE;
                        OBJ.HA ha = rootX.SIMULATION[i].AUTO.HA;

                        writer.WriteLine("@N GENERAL     NYERS NREPS START SDATE RSEED SNAME.................... SMODEL");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            " GE         ",
                            (UTIL.SpaceLeft(ge.NYERS, 6)),
                            (UTIL.SpaceLeft(ge.NREPS, 6)),
                            (UTIL.SpaceLeft(ge.START, 6)),
                            (UTIL.SpaceLeft(ge.SDATE, 6)),
                            (UTIL.SpaceLeft(ge.RSEED, 6)),
                            (UTIL.SpaceRight(ge.SNAME, 26)),
                            (UTIL.SpaceRight(ge.SMODEL, ge.SMODEL.Length + 1))
                        ));
                        writer.WriteLine("@N OPTIONS     WATER NITRO SYMBI PHOSP POTAS DISES  CHEM  TILL   CO2");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            " OP         ",
                            (UTIL.SpaceLeft(op.WATER, 6)),
                            (UTIL.SpaceLeft(op.NITRO, 6)),
                            (UTIL.SpaceLeft(op.SYMBI, 6)),
                            (UTIL.SpaceLeft(op.PHOSP, 6)),
                            (UTIL.SpaceLeft(op.POTAS, 6)),
                            (UTIL.SpaceLeft(op.DISES, 6)),
                            (UTIL.SpaceLeft(op.CHEM, 6)),
                            (UTIL.SpaceLeft(op.TILL, 6)),
                            (UTIL.SpaceLeft(op.CO2, 6))
                        ));
                        writer.WriteLine("@N METHODS     WTHER INCON LIGHT EVAPO INFIL PHOTO HYDRO NSWIT MESOM MESEV MESOL");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            " ME         ",
                            (UTIL.SpaceLeft(me.WTHER, 6)),
                            (UTIL.SpaceLeft(me.INCON, 6)),
                            (UTIL.SpaceLeft(me.LIGHT, 6)),
                            (UTIL.SpaceLeft(me.EVAPO, 6)),
                            (UTIL.SpaceLeft(me.INFIL, 6)),
                            (UTIL.SpaceLeft(me.PHOTO, 6)),
                            (UTIL.SpaceLeft(me.HYDRO, 6)),
                            (UTIL.SpaceLeft(me.NSWIT, 6)),
                            (UTIL.SpaceLeft(me.MESOM, 6)),
                            (UTIL.SpaceLeft(me.MESEV, 6)),
                            (UTIL.SpaceLeft(me.MESOL, 6))
                        ));
                        writer.WriteLine("@N MANAGEMENT  PLANT IRRIG FERTI RESID HARVS");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            " MA         ",
                            (UTIL.SpaceLeft(ma.PLANT, 6)),
                            (UTIL.SpaceLeft(ma.IRRIG, 6)),
                            (UTIL.SpaceLeft(ma.FERTI, 6)),
                            (UTIL.SpaceLeft(ma.RESID, 6)),
                            (UTIL.SpaceLeft(ma.HARVS, 6))
                        ));
                        writer.WriteLine("@N OUTPUTS     FNAME OVVEW SUMRY FROPT GROUT CAOUT WAOUT NIOUT MIOUT DIOUT VBOSE CHOUT OPOUT");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            " OU         ",
                            (UTIL.SpaceLeft(ou.FNAME, 6)),
                            (UTIL.SpaceLeft(ou.OVVEW, 6)),
                            (UTIL.SpaceLeft(ou.SUMRY, 6)),
                            (UTIL.SpaceLeft(ou.FROPT, 6)),
                            (UTIL.SpaceLeft(ou.GROUT, 6)),
                            (UTIL.SpaceLeft(ou.CAOUT, 6)),
                            (UTIL.SpaceLeft(ou.WAOUT, 6)),
                            (UTIL.SpaceLeft(ou.NIOUT, 6)),
                            (UTIL.SpaceLeft(ou.MIOUT, 6)),
                            (UTIL.SpaceLeft(ou.DIOUT, 6)),
                            (UTIL.SpaceLeft(ou.VBOSE, 6)),
                            (UTIL.SpaceLeft(ou.CHOUT, 6)),
                            (UTIL.SpaceLeft(ou.OPOUT, 6))
                        ));
                        writer.WriteLine("");
                        writer.WriteLine("@  AUTOMATIC MANAGEMENT");
                        writer.WriteLine("@N PLANTING    PFRST PLAST PH2OL PH2OU PH2OD PSTMX PSTMN");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            " PL         ",
                            (UTIL.SpaceLeft(pl.PFRST, 6)),
                            (UTIL.SpaceLeft(pl.PLAST, 6)),
                            (UTIL.SpaceLeft(pl.PH2OL, 6)),
                            (UTIL.SpaceLeft(pl.PH2OU, 6)),
                            (UTIL.SpaceLeft(pl.PH2OD, 6)),
                            (UTIL.SpaceLeft(pl.PSTMX, 6)),
                            (UTIL.SpaceLeft(pl.PSTMN, 6))
                        ));
                        writer.WriteLine("@N IRRIGATION  IMDEP ITHRL ITHRU IROFF IMETH IRAMT IREFF");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            " IR         ",
                            (UTIL.SpaceLeft(ir.IMDEP, 6)),
                            (UTIL.SpaceLeft(ir.ITHRL, 6)),
                            (UTIL.SpaceLeft(ir.ITHRU, 6)),
                            (UTIL.SpaceLeft(ir.IROFF, 6)),
                            (UTIL.SpaceLeft(ir.IMETH, 6)),
                            (UTIL.SpaceLeft(ir.IRAMT, 6)),
                            (UTIL.SpaceLeft(ir.IREFF, 6))
                        ));
                        writer.WriteLine("@N NITROGEN    NMDEP NMTHR NAMNT NCODE NAOFF");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            " NI         ",
                            (UTIL.SpaceLeft(ni.NMDEP, 6)),
                            (UTIL.SpaceLeft(ni.NMTHR, 6)),
                            (UTIL.SpaceLeft(ni.NAMNT, 6)),
                            (UTIL.SpaceLeft(ni.NCODE, 6)),
                            (UTIL.SpaceLeft(ni.NAOFF, 6))
                        ));
                        writer.WriteLine("@N RESIDUES    RIPCN RTIME RIDEP");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            " RE         ",
                            (UTIL.SpaceLeft(re.RIPCN, 6)),
                            (UTIL.SpaceLeft(re.RTIME, 6)),
                            (UTIL.SpaceLeft(re.RIDEP, 6))
                        ));
                        writer.WriteLine("@N HARVEST     HFRST HLAST HPCNP HPCNR");
                        writer.WriteLine(string.Concat(
                            ((i < 10 ? " " + i.ToString() : i.ToString())),
                            " HA         ",
                            (UTIL.SpaceLeft(ha.HFRST, 6)),
                            (UTIL.SpaceLeft(ha.HLAST, 6)),
                            (UTIL.SpaceLeft(ha.HPCNP, 6)),
                            (UTIL.SpaceLeft(ha.HPCNR, 6))
                        ));
                        writer.WriteLine("");
                    }
                }
            }
        }

        class READ
        {
            public static OBJ.GENERAL readGENERAL(List<string> lines)
            {
                OBJ.GENERAL obj = new OBJ.GENERAL();
                string hdr = string.Empty;
                foreach (string l in lines)
                {
                    if (l.Length > 0)
                    {
                        if (l.Substring(0, 1) == "@")
                        {
                            if (l.Substring(0, 3) != "@ P")
                            {
                                hdr = l.Substring(1).Trim();
                            }
                            else
                            {
                                hdr = "PLOT";
                            }
                        }
                        else
                        {
                            switch (hdr.ToUpper())
                            {
                                case "PEOPLE":
                                    obj.PEOPLE = l.Trim();
                                    break;
                                case "ADDRESS":
                                    obj.ADDRESS = l.Trim();
                                    break;
                                case "SITE":
                                    obj.SITE = l.Trim();
                                    break;
                                case "NOTES":
                                    obj.NOTES = l.Trim();
                                    break;
                                case "PLOT":
                                    obj.PAREA = l.Substring(0, 7).Trim();
                                    obj.PRNO = l.Substring(7, 6).Trim();
                                    obj.PLEN = l.Substring(13, 6).Trim();
                                    obj.PLDR = l.Substring(19, 6).Trim();
                                    obj.PLSP = l.Substring(25, 6).Trim();
                                    obj.PLAY = l.Substring(31, 6).Trim();
                                    obj.HAREA = l.Substring(37, 6).Trim();
                                    obj.HRNO = l.Substring(43, 6).Trim();
                                    obj.HLEN = l.Substring(49, 6).Trim();
                                    obj.HARM = l.Substring(55).Trim();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                return obj;
            }

            public static List<OBJ.TREATMENT> readTREATMENT(List<string> lines)
            {
                List<OBJ.TREATMENT> objs = new List<OBJ.TREATMENT>();
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "@" || marker == "!"))
                        {
                            OBJ.TREATMENT obj = new OBJ.TREATMENT
                            {
                                N = int.Parse(l.Substring(0, 2).Trim()),
                                R = int.Parse(l.Substring(2, 2).Trim()),
                                O = int.Parse(l.Substring(4, 2).Trim()),
                                C = int.Parse(l.Substring(6, 2).Trim()),
                                TNAME = l.Substring(8, 26).Trim(),
                                CU = int.Parse(l.Substring(34, 3).Trim()),
                                FL = int.Parse(l.Substring(37, 3).Trim()),
                                SA = int.Parse(l.Substring(40, 3).Trim()),
                                IC = int.Parse(l.Substring(43, 3).Trim()),
                                MP = int.Parse(l.Substring(46, 3).Trim()),
                                MI = int.Parse(l.Substring(49, 3).Trim()),
                                MF = int.Parse(l.Substring(52, 3).Trim()),
                                MR = int.Parse(l.Substring(55, 3).Trim()),
                                MC = int.Parse(l.Substring(58, 3).Trim()),
                                MT = int.Parse(l.Substring(61, 3).Trim()),
                                ME = int.Parse(l.Substring(64, 3).Trim()),
                                MH = int.Parse(l.Substring(67, 3).Trim()),
                                SM = int.Parse(l.Substring(70).Trim())
                            };
                            objs.Add(obj);
                        }
                    }
                }
                return objs;
            }

            public static Dictionary<int, OBJ.CULTIVAR> readCULTIVAR(List<string> lines)
            {
                Dictionary<int, OBJ.CULTIVAR> objs = new Dictionary<int, OBJ.CULTIVAR>();
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "@" || marker == "!"))
                        {
                            OBJ.CULTIVAR obj = new OBJ.CULTIVAR
                            {
                                C = int.Parse(l.Substring(0, 2).Trim()),
                                CR = l.Substring(2, 3).Trim(),
                                INGENO = l.Substring(5, 7).Trim(),
                                CNAME = l.Substring(12).Trim()
                            };
                            objs.Add(obj.C, obj);
                        }
                    }
                }
                return objs;
            }

            public static Dictionary<int, OBJ.FIELD> readFIELD(List<string> lines)
            {
                Dictionary<int, OBJ.FIELD> objs = new Dictionary<int, OBJ.FIELD>();
                Dictionary<int, OBJ.FIELD0> dict0 = new Dictionary<int, OBJ.FIELD0>();
                Dictionary<int, OBJ.FIELD1> dict1 = new Dictionary<int, OBJ.FIELD1>();

                int flag = -1;

                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "!"))
                        {
                            if (l.Length > 5)
                            {
                                if (l.Substring(0, 5) == "@L ID")
                                {
                                    flag = 0;
                                }
                                else if (l.Substring(0, 5) == "@L ..")
                                {
                                    flag = 1;
                                }
                                else
                                {
                                    int L;
                                    switch (flag)
                                    {
                                        case 0:
                                            L = int.Parse(l.Substring(0, 2).Trim());
                                            OBJ.FIELD0 obj0 = new OBJ.FIELD0
                                            {
                                                //L = int.Parse(l.Substring(0, 2).Trim()),
                                                ID_FIELD = l.Substring(2, 9).Trim(),
                                                WSTA = l.Substring(11, 9).Trim(),
                                                FLSA = l.Substring(20, 6).Trim(),
                                                FLOB = l.Substring(26, 6).Trim(),
                                                FLDT = l.Substring(32, 6).Trim(),
                                                FLDD = l.Substring(38, 6).Trim(),
                                                FLDS = l.Substring(44, 6).Trim(),
                                                FLST = l.Substring(50, 6).Trim(),
                                                SLTX = l.Substring(56, 6).Trim(),
                                                SLDP = l.Substring(62, 5).Trim(),
                                                ID_SOIL = l.Substring(67, 12).Trim(),
                                                FLNAME = l.Substring(79).Trim()
                                            };
                                            dict0.Add(L, obj0);
                                            break;
                                        case 1:
                                            L = int.Parse(l.Substring(0, 2).Trim());
                                            OBJ.FIELD1 obj1 = new OBJ.FIELD1
                                            {
                                                //L = int.Parse(l.Substring(0, 2).Trim()),
                                                XCRD = l.Substring(2, 16).Trim(),
                                                YCRD = l.Substring(18, 16).Trim(),
                                                ELEV = l.Substring(34, 10).Trim(),
                                                AREA = l.Substring(44, 18).Trim(),
                                                SLEN = l.Substring(62, 6).Trim(),
                                                FLWR = l.Substring(68, 6).Trim(),
                                                SLAS = l.Substring(74, 6).Trim(),
                                                FLHST = l.Substring(80, 6).Trim(),
                                                FHDUR = l.Substring(86).Trim()
                                            };
                                            dict1.Add(L, obj1);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
                foreach (int k in dict0.Keys)
                {
                    OBJ.FIELD obj = new OBJ.FIELD
                    {
                        L = k,
                        FIELD_0 = dict0[k],
                        FIELD_1 = dict1[k]
                    };
                    objs.Add(obj.L, obj);
                }
                return objs;
            }

            public static Dictionary<int, OBJ.SOIL> readSOIL(List<string> lines)
            {
                Dictionary<int, OBJ.SOIL> objs = new Dictionary<int, OBJ.SOIL>();
                Dictionary<int, OBJ.SOIL0> dict0 = new Dictionary<int, OBJ.SOIL0>();
                Dictionary<int, List<OBJ.SOIL1>> dict1 = new Dictionary<int, List<OBJ.SOIL1>>();

                int flag = -1;
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "!"))
                        {
                            if (l.Length > 5)
                            {
                                if (l.Substring(0, 5) == "@A SA")
                                {
                                    flag = 0;
                                }
                                else if (l.Substring(0, 5) == "@A  S")
                                {
                                    flag = 1;
                                }
                                else
                                {
                                    int A;
                                    switch (flag)
                                    {
                                        case 0:
                                            A = int.Parse(l.Substring(0, 2).Trim());
                                            OBJ.SOIL0 obj0 = new OBJ.SOIL0
                                            {
                                                //A = int.Parse(l.Substring(0, 2).Trim()),
                                                SADAT = l.Substring(2, 6).Trim(),
                                                SMHB = l.Substring(8, 6).Trim(),
                                                SMPX = l.Substring(14, 6).Trim(),
                                                SMKE = l.Substring(20, 6).Trim(),
                                                SANAME = l.Substring(26).Trim()
                                            };
                                            dict0.Add(A, obj0);
                                            break;
                                        case 1:
                                            A = int.Parse(l.Substring(0, 2).Trim());
                                            OBJ.SOIL1 obj1 = new OBJ.SOIL1
                                            {
                                                //A = int.Parse(l.Substring(0, 2).Trim()),
                                                SABL = l.Substring(2, 6).Trim(),
                                                SADM = l.Substring(8, 6).Trim(),
                                                SAOC = l.Substring(14, 6).Trim(),
                                                SANI = l.Substring(20, 6).Trim(),
                                                SAPHW = l.Substring(26, 6).Trim(),
                                                SAPHB = l.Substring(32, 6).Trim(),
                                                SAPX = l.Substring(38, 6).Trim(),
                                                SAKE = l.Substring(44, 6).Trim(),
                                                SASC = l.Substring(50).Trim()
                                            };

                                            if (dict1.ContainsKey(A))
                                            {
                                                List<OBJ.SOIL1> A1 = dict1[A];
                                                A1.Add(obj1);
                                                dict1.Remove(A);
                                                dict1.Add(A, A1);
                                            }
                                            else
                                            {
                                                List<OBJ.SOIL1> A1 = new List<OBJ.SOIL1>();
                                                A1.Add(obj1);
                                                dict1.Add(A, A1);
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
                foreach (int k in dict0.Keys)
                {
                    OBJ.SOIL obj = new OBJ.SOIL
                    {
                        A = k,
                        SOIL_0 = dict0[k],
                        SOIL_1 = dict1[k]
                    };
                    objs.Add(obj.A, obj);
                }
                return objs;
            }

            public static Dictionary<int, OBJ.ICONDITION> readICONDITION(List<string> lines)
            {
                Dictionary<int, OBJ.ICONDITION> objs = new Dictionary<int, OBJ.ICONDITION>();
                Dictionary<int, OBJ.ICONDITION0> dict0 = new Dictionary<int, OBJ.ICONDITION0>();
                Dictionary<int, List<OBJ.ICONDITION1>> dict1 = new Dictionary<int, List<OBJ.ICONDITION1>>();

                int flag = -1;
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "!"))
                        {
                            if (l.Length > 5)
                            {
                                if (l.Substring(0, 5) == "@C   ")
                                {
                                    flag = 0;
                                }
                                else if (l.Substring(0, 5) == "@C  I")
                                {
                                    flag = 1;
                                }
                                else
                                {
                                    int C;
                                    switch (flag)
                                    {
                                        case 0:
                                            C = int.Parse(l.Substring(0, 2).Trim());
                                            OBJ.ICONDITION0 obj0 = new OBJ.ICONDITION0
                                            {
                                                //C = int.Parse(l.Substring(0, 2).Trim()),
                                                PCR = l.Substring(2, 6).Trim(),
                                                ICDAT = l.Substring(8, 6).Trim(),
                                                ICRT = l.Substring(14, 6).Trim(),
                                                ICND = l.Substring(20, 6).Trim(),
                                                ICRN = l.Substring(26, 6).Trim(),
                                                ICRE = l.Substring(32, 6).Trim(),
                                                ICWD = l.Substring(38, 6).Trim(),
                                                ICRES = l.Substring(44, 6).Trim(),
                                                ICREN = l.Substring(50, 6).Trim(),
                                                ICREP = l.Substring(56, 6).Trim(),
                                                ICRIP = l.Substring(62, 6).Trim(),
                                                ICRID = l.Substring(68, 6).Trim(),
                                                ICNAME = l.Substring(74).Trim()
                                            };
                                            dict0.Add(C, obj0);
                                            break;
                                        case 1:
                                            C = int.Parse(l.Substring(0, 2).Trim());
                                            OBJ.ICONDITION1 obj1 = new OBJ.ICONDITION1
                                            {
                                                //C = int.Parse(l.Substring(0, 2).Trim()),
                                                ICBL = l.Substring(2, 6).Trim(),
                                                SH2O = l.Substring(8, 6).Trim(),
                                                SNH4 = l.Substring(14, 6).Trim(),
                                                SNO3 = l.Substring(20).Trim()
                                            };

                                            if (dict1.ContainsKey(C))
                                            {
                                                List<OBJ.ICONDITION1> C1 = dict1[C];
                                                C1.Add(obj1);
                                                dict1.Remove(C);
                                                dict1.Add(C, C1);
                                            }
                                            else
                                            {
                                                List<OBJ.ICONDITION1> C1 = new List<OBJ.ICONDITION1>();
                                                C1.Add(obj1);
                                                dict1.Add(C, C1);
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
                foreach (int k in dict0.Keys)
                {
                    OBJ.ICONDITION obj = new OBJ.ICONDITION
                    {
                        C = k,
                        ICONDITION_0 = dict0[k],
                        ICONDITION_1 = dict1[k]
                    };
                    objs.Add(obj.C, obj);
                }
                return objs;
            }

            public static Dictionary<int, OBJ.IRRIGATION> readIRRIGATION(List<string> lines)
            {
                Dictionary<int, OBJ.IRRIGATION> objs = new Dictionary<int, OBJ.IRRIGATION>();
                Dictionary<int, OBJ.IRRIGATION0> dict0 = new Dictionary<int, OBJ.IRRIGATION0>();
                Dictionary<int, List<OBJ.IRRIGATION1>> dict1 = new Dictionary<int, List<OBJ.IRRIGATION1>>();

                int flag = -1;
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "!"))
                        {
                            if (l.Length > 5)
                            {
                                if (l.Substring(0, 5) == "@I  E")
                                {
                                    flag = 0;
                                }
                                else if (l.Substring(0, 5) == "@I ID")
                                {
                                    flag = 1;
                                }
                                else
                                {
                                    int I;
                                    switch (flag)
                                    {
                                        case 0:
                                            I = int.Parse(l.Substring(0, 2).Trim());
                                            OBJ.IRRIGATION0 obj0 = new OBJ.IRRIGATION0
                                            {
                                                //I = int.Parse(l.Substring(0, 2).Trim()),
                                                EFIR = l.Substring(2, 6).Trim(),
                                                IDEP = l.Substring(8, 6).Trim(),
                                                ITHR = l.Substring(14, 6).Trim(),
                                                IEPT = l.Substring(20, 6).Trim(),
                                                IOFF = l.Substring(26, 6).Trim(),
                                                IAME = l.Substring(32, 6).Trim(),
                                                IAMT = l.Substring(38, 6).Trim(),
                                                IRNAME = l.Substring(44).Trim()
                                            };
                                            dict0.Add(I, obj0);
                                            break;
                                        case 1:
                                            I = int.Parse(l.Substring(0, 2).Trim());
                                            OBJ.IRRIGATION1 obj1 = new OBJ.IRRIGATION1
                                            {
                                                //I = int.Parse(l.Substring(0, 2).Trim()),
                                                IDATE = l.Substring(2, 6).Trim(),
                                                IROP = l.Substring(8, 6).Trim(),
                                                IRVAL = l.Substring(14).Trim()
                                            };

                                            if (dict1.ContainsKey(I))
                                            {
                                                List<OBJ.IRRIGATION1> I1 = dict1[I];
                                                I1.Add(obj1);
                                                dict1.Remove(I);
                                                dict1.Add(I, I1);
                                            }
                                            else
                                            {
                                                List<OBJ.IRRIGATION1> I1 = new List<OBJ.IRRIGATION1>();
                                                I1.Add(obj1);
                                                dict1.Add(I, I1);
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
                foreach (int k in dict0.Keys)
                {
                    OBJ.IRRIGATION obj = new OBJ.IRRIGATION
                    {
                        I = k,
                        IRRIGATION_0 = dict0[k],
                        IRRIGATION_1 = dict1[k]
                    };
                    objs.Add(obj.I, obj);
                }
                return objs;
            }

            public static Dictionary<int, OBJ.PLANTING> readPLANTING(List<string> lines)
            {
                Dictionary<int, OBJ.PLANTING> objs = new Dictionary<int, OBJ.PLANTING>();
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "@" || marker == "!"))
                        {
                            OBJ.PLANTING obj = new OBJ.PLANTING
                            {
                                P = int.Parse(l.Substring(0, 2).Trim()),
                                PDATE = l.Substring(2, 6).Trim(),
                                EDATE = l.Substring(8, 6).Trim(),
                                PPOP = l.Substring(14, 6).Trim(),
                                PPOE = l.Substring(20, 6).Trim(),
                                PLME = l.Substring(26, 6).Trim(),
                                PLDS = l.Substring(32, 6).Trim(),
                                PLRS = l.Substring(38, 6).Trim(),
                                PLRD = l.Substring(44, 6).Trim(),
                                PLDP = l.Substring(50, 6).Trim(),
                                PLWT = l.Substring(56, 6).Trim(),
                                PAGE = l.Substring(62, 6).Trim(),
                                PENV = l.Substring(68, 6).Trim(),
                                PLPH = l.Substring(74, 6).Trim(),
                                SPRL = l.Substring(80, 6).Trim(),
                                PLNAME = l.Substring(86).Trim()
                            };
                            objs.Add(obj.P, obj);
                        }
                    }
                }
                return objs;
            }

            public static Dictionary<int, List<OBJ.FERTILIZER>> readFERTILIZER(List<string> lines)
            {
                Dictionary<int, List<OBJ.FERTILIZER>> objs = new Dictionary<int, List<OBJ.FERTILIZER>>();
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "@" || marker == "!"))
                        {
                            OBJ.FERTILIZER obj = new OBJ.FERTILIZER
                            {
                                F = int.Parse(l.Substring(0, 2).Trim()),
                                FDATE = l.Substring(2, 6).Trim(),
                                FMCD = l.Substring(8, 6).Trim(),
                                FACD = l.Substring(14, 6).Trim(),
                                FDEP = l.Substring(20, 6).Trim(),
                                FAMN = l.Substring(26, 6).Trim(),
                                FAMP = l.Substring(32, 6).Trim(),
                                FAMK = l.Substring(38, 6).Trim(),
                                FAMC = l.Substring(44, 6).Trim(),
                                FAMO = l.Substring(50, 6).Trim(),
                                FOCD = l.Substring(56, 6).Trim(),
                                FERNAME = l.Substring(62).Trim()
                            };
                            if (objs.ContainsKey(obj.F))
                            {
                                List<OBJ.FERTILIZER> f = objs[obj.F];
                                f.Add(obj);
                                objs.Remove(obj.F);
                                objs.Add(obj.F, f);
                            }
                            else
                            {
                                List<OBJ.FERTILIZER> f = new List<OBJ.FERTILIZER>();
                                f.Add(obj);
                                objs.Add(obj.F, f);
                            }
                        }
                    }
                }
                return objs;
            }

            public static Dictionary<int, List<OBJ.RESIDUE>> readRESIDUE(List<string> lines)
            {
                Dictionary<int, List<OBJ.RESIDUE>> objs = new Dictionary<int, List<OBJ.RESIDUE>>();
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "@" || marker == "!"))
                        {
                            OBJ.RESIDUE obj = new OBJ.RESIDUE
                            {
                                R = int.Parse(l.Substring(0, 2).Trim()),
                                RDATE = l.Substring(2, 6).Trim(),
                                RCOD = l.Substring(8, 6).Trim(),
                                RAMT = l.Substring(14, 6).Trim(),
                                RESN = l.Substring(20, 6).Trim(),
                                RESP = l.Substring(26, 6).Trim(),
                                RESK = l.Substring(32, 6).Trim(),
                                RINP = l.Substring(38, 6).Trim(),
                                RDEP = l.Substring(44, 6).Trim(),
                                RMET = l.Substring(50, 6).Trim(),
                                RENAME = l.Substring(56).Trim()
                            };
                            if (objs.ContainsKey(obj.R))
                            {
                                List<OBJ.RESIDUE> r = objs[obj.R];
                                r.Add(obj);
                                objs.Remove(obj.R);
                                objs.Add(obj.R, r);
                            }
                            else
                            {
                                List<OBJ.RESIDUE> r = new List<OBJ.RESIDUE>();
                                r.Add(obj);
                                objs.Add(obj.R, r);
                            }
                        }
                    }
                }
                return objs;
            }

            public static Dictionary<int, List<OBJ.CHEMICAL>> readCHEMICAL(List<string> lines)
            {
                Dictionary<int, List<OBJ.CHEMICAL>> objs = new Dictionary<int, List<OBJ.CHEMICAL>>();
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "@" || marker == "!"))
                        {
                            OBJ.CHEMICAL obj = new OBJ.CHEMICAL
                            {
                                C = int.Parse(l.Substring(0, 2).Trim()),
                                CDATE = l.Substring(2, 6).Trim(),
                                CHCOD = l.Substring(8, 6).Trim(),
                                CHAMT = l.Substring(14, 6).Trim(),
                                CHME = l.Substring(20, 6).Trim(),
                                CHDEP = l.Substring(26, 6).Trim(),
                                CHT = l.Substring(32, 6).Trim(),
                                CHNAME = l.Substring(38).Trim()
                            };
                            if (objs.ContainsKey(obj.C))
                            {
                                List<OBJ.CHEMICAL> c = objs[obj.C];
                                c.Add(obj);
                                objs.Remove(obj.C);
                                objs.Add(obj.C, c);
                            }
                            else
                            {
                                List<OBJ.CHEMICAL> c = new List<OBJ.CHEMICAL>();
                                c.Add(obj);
                                objs.Add(obj.C, c);
                            }
                        }
                    }
                }
                return objs;
            }

            public static Dictionary<int, List<OBJ.TILLAGE>> readTILLAGE(List<string> lines)
            {
                Dictionary<int, List<OBJ.TILLAGE>> objs = new Dictionary<int, List<OBJ.TILLAGE>>();
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "@" || marker == "!"))
                        {
                            OBJ.TILLAGE obj = new OBJ.TILLAGE
                            {
                                T = int.Parse(l.Substring(0, 2).Trim()),
                                TDATE = l.Substring(2, 6).Trim(),
                                TIMPL = l.Substring(8, 6).Trim(),
                                TDEP = l.Substring(14, 6).Trim(),
                                TNAME = l.Substring(20).Trim()
                            };
                            if (objs.ContainsKey(obj.T))
                            {
                                List<OBJ.TILLAGE> t = objs[obj.T];
                                t.Add(obj);
                                objs.Remove(obj.T);
                                objs.Add(obj.T, t);
                            }
                            else
                            {
                                List<OBJ.TILLAGE> t = new List<OBJ.TILLAGE>();
                                t.Add(obj);
                                objs.Add(obj.T, t);
                            }
                        }
                    }
                }
                return objs;
            }

            public static Dictionary<int, List<OBJ.ENVIRONMENT>> readENVIRONMENT(List<string> lines)
            {
                Dictionary<int, List<OBJ.ENVIRONMENT>> objs = new Dictionary<int, List<OBJ.ENVIRONMENT>>();
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "@" || marker == "!"))
                        {
                            OBJ.ENVIRONMENT obj = new OBJ.ENVIRONMENT
                            {
                                E = int.Parse(l.Substring(0, 2).Trim()),
                                ODATE = l.Substring(2, 6).Trim(),
                                MEDAY = l.Substring(8, 1).Trim(),
                                EDAY = l.Substring(9, 5).Trim(),
                                MERAD = l.Substring(14, 1).Trim(),
                                ERAD = l.Substring(15, 5).Trim(),
                                MEMAX = l.Substring(20, 1).Trim(),
                                EMAX = l.Substring(21, 5).Trim(),
                                MEMIN = l.Substring(26, 1).Trim(),
                                EMIN = l.Substring(27, 5).Trim(),
                                MERAIN = l.Substring(32, 1).Trim(),
                                ERAIN = l.Substring(33, 5).Trim(),
                                MECO2 = l.Substring(38, 1).Trim(),
                                ECO2 = l.Substring(39, 5).Trim(),
                                MEDEW = l.Substring(44, 1).Trim(),
                                EDEW = l.Substring(45, 5).Trim(),
                                MEWIND = l.Substring(50, 1).Trim(),
                                EWIND = l.Substring(51, 5).Trim(),
                                ENVNAME = l.Substring(56).Trim()
                            };
                            if (objs.ContainsKey(obj.E))
                            {
                                List<OBJ.ENVIRONMENT> e = objs[obj.E];
                                e.Add(obj);
                                objs.Remove(obj.E);
                                objs.Add(obj.E, e);
                            }
                            else
                            {
                                List<OBJ.ENVIRONMENT> e = new List<OBJ.ENVIRONMENT>();
                                e.Add(obj);
                                objs.Add(obj.E, e);
                            }
                        }
                    }
                }
                return objs;
            }

            public static Dictionary<int, List<OBJ.HARVEST>> readHARVEST(List<string> lines)
            {
                Dictionary<int, List<OBJ.HARVEST>> objs = new Dictionary<int, List<OBJ.HARVEST>>();
                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0)
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "@" || marker == "!"))
                        {
                            OBJ.HARVEST obj = new OBJ.HARVEST
                            {
                                H = int.Parse(l.Substring(0, 2).Trim()),
                                HDATE = l.Substring(2, 6).Trim(),
                                HSTG = l.Substring(8, 6).Trim(),
                                HCOM = l.Substring(14, 6).Trim(),
                                HSIZE = l.Substring(20, 6).Trim(),
                                HPC = l.Substring(26, 6).Trim(),
                                HBPC = l.Substring(32, 6).Trim(),
                                HNAME = l.Substring(38).Trim()
                            };
                            if (objs.ContainsKey(obj.H))
                            {
                                List<OBJ.HARVEST> h = objs[obj.H];
                                h.Add(obj);
                                objs.Remove(obj.H);
                                objs.Add(obj.H, h);
                            }
                            else
                            {
                                List<OBJ.HARVEST> h = new List<OBJ.HARVEST>();
                                h.Add(obj);
                                objs.Add(obj.H, h);
                            }
                        }
                    }
                }
                return objs;
            }

            public static Dictionary<int, OBJ.SIMULATION> readSIMULATION(List<string> lines)
            {
                Dictionary<int, OBJ.GE> dictGE = new Dictionary<int, OBJ.GE>();
                Dictionary<int, OBJ.OP> dictOP = new Dictionary<int, OBJ.OP>();
                Dictionary<int, OBJ.ME> dictME = new Dictionary<int, OBJ.ME>();
                Dictionary<int, OBJ.MA> dictMA = new Dictionary<int, OBJ.MA>();
                Dictionary<int, OBJ.OU> dictOU = new Dictionary<int, OBJ.OU>();
                Dictionary<int, OBJ.PL> dictPL = new Dictionary<int, OBJ.PL>();
                Dictionary<int, OBJ.IR> dictIR = new Dictionary<int, OBJ.IR>();
                Dictionary<int, OBJ.NI> dictNI = new Dictionary<int, OBJ.NI>();
                Dictionary<int, OBJ.RE> dictRE = new Dictionary<int, OBJ.RE>();
                Dictionary<int, OBJ.HA> dictHA = new Dictionary<int, OBJ.HA>();

                string header = string.Empty;

                foreach (string l in lines)
                {
                    if (l.Trim().Length > 0 && l != "\u001a")
                    {
                        string marker = l.Substring(0, 1);
                        if (!(marker == "*" || marker == "@" || marker == "!"))
                        {
                            header = l.Substring(2, 3).Trim().ToUpper();
                            int N;
                            switch (header)
                            {
                                case "GE":
                                    N = int.Parse(l.Substring(0, 2).Trim());
                                    OBJ.GE oGE = new OBJ.GE
                                    {
                                        //N = int.Parse(l.Substring(0, 2).Trim()),
                                        NYERS = l.Substring(14, 6).Trim(),
                                        NREPS = l.Substring(20, 6).Trim(),
                                        START = l.Substring(26, 6).Trim(),
                                        SDATE = l.Substring(32, 6).Trim(),
                                        RSEED = l.Substring(38, 6).Trim(),
                                        SNAME = l.Substring(44, 26).Trim(),
                                        SMODEL = l.Substring(70).Trim()
                                    };
                                    dictGE.Add(N, oGE);
                                    break;
                                case "OP":
                                    N = int.Parse(l.Substring(0, 2).Trim());
                                    OBJ.OP oOP = new OBJ.OP
                                    {
                                        //N = int.Parse(l.Substring(0, 2).Trim()),
                                        WATER = l.Substring(14, 6).Trim(),
                                        NITRO = l.Substring(20, 6).Trim(),
                                        SYMBI = l.Substring(26, 6).Trim(),
                                        PHOSP = l.Substring(32, 6).Trim(),
                                        POTAS = l.Substring(38, 6).Trim(),
                                        DISES = l.Substring(44, 6).Trim(),
                                        CHEM = l.Substring(50, 6).Trim(),
                                        TILL = l.Substring(56, 6).Trim(),
                                        CO2 = l.Substring(62).Trim()
                                    };
                                    dictOP.Add(N, oOP);
                                    break;
                                case "ME":
                                    N = int.Parse(l.Substring(0, 2).Trim());
                                    OBJ.ME oME = new OBJ.ME
                                    {
                                        //N = int.Parse(l.Substring(0, 2).Trim()),
                                        WTHER = l.Substring(14, 6).Trim(),
                                        INCON = l.Substring(20, 6).Trim(),
                                        LIGHT = l.Substring(26, 6).Trim(),
                                        EVAPO = l.Substring(32, 6).Trim(),
                                        INFIL = l.Substring(38, 6).Trim(),
                                        PHOTO = l.Substring(44, 6).Trim(),
                                        HYDRO = l.Substring(50, 6).Trim(),
                                        NSWIT = l.Substring(56, 6).Trim(),
                                        MESOM = l.Substring(62, 6).Trim(),
                                        MESEV = l.Substring(68, 6).Trim(),
                                        MESOL = l.Substring(74).Trim()
                                    };
                                    dictME.Add(N, oME);
                                    break;
                                case "MA":
                                    N = int.Parse(l.Substring(0, 2).Trim());
                                    OBJ.MA oMA = new OBJ.MA
                                    {
                                        //N = int.Parse(l.Substring(0, 2).Trim()),
                                        PLANT = l.Substring(14, 6).Trim(),
                                        IRRIG = l.Substring(20, 6).Trim(),
                                        FERTI = l.Substring(26, 6).Trim(),
                                        RESID = l.Substring(32, 6).Trim(),
                                        HARVS = l.Substring(38).Trim()
                                    };
                                    dictMA.Add(N, oMA);
                                    break;
                                case "OU":
                                    N = int.Parse(l.Substring(0, 2).Trim());
                                    OBJ.OU oOU = new OBJ.OU
                                    {
                                        //N = int.Parse(l.Substring(0, 2).Trim()),
                                        FNAME = l.Substring(14, 6).Trim(),
                                        OVVEW = l.Substring(20, 6).Trim(),
                                        SUMRY = l.Substring(26, 6).Trim(),
                                        FROPT = l.Substring(32, 6).Trim(),
                                        GROUT = l.Substring(38, 6).Trim(),
                                        CAOUT = l.Substring(44, 6).Trim(),
                                        WAOUT = l.Substring(50, 6).Trim(),
                                        NIOUT = l.Substring(56, 6).Trim(),
                                        MIOUT = l.Substring(62, 6).Trim(),
                                        DIOUT = l.Substring(68, 6).Trim(),
                                        VBOSE = l.Substring(74, 6).Trim(),
                                        CHOUT = l.Substring(80, 6).Trim(),
                                        OPOUT = l.Substring(86).Trim()
                                    };
                                    dictOU.Add(N, oOU);
                                    break;
                                case "PL":
                                    N = int.Parse(l.Substring(0, 2).Trim());
                                    OBJ.PL oPL = new OBJ.PL
                                    {
                                        //N = int.Parse(l.Substring(0, 2).Trim()),
                                        PFRST = l.Substring(14, 6).Trim(),
                                        PLAST = l.Substring(20, 6).Trim(),
                                        PH2OL = l.Substring(26, 6).Trim(),
                                        PH2OU = l.Substring(32, 6).Trim(),
                                        PH2OD = l.Substring(38, 6).Trim(),
                                        PSTMX = l.Substring(44, 6).Trim(),
                                        PSTMN = l.Substring(50).Trim()
                                    };
                                    dictPL.Add(N, oPL);
                                    break;
                                case "IR":
                                    N = int.Parse(l.Substring(0, 2).Trim());
                                    OBJ.IR oIR = new OBJ.IR
                                    {
                                        //N = int.Parse(l.Substring(0, 2).Trim()),
                                        IMDEP = l.Substring(14, 6).Trim(),
                                        ITHRL = l.Substring(20, 6).Trim(),
                                        ITHRU = l.Substring(26, 6).Trim(),
                                        IROFF = l.Substring(32, 6).Trim(),
                                        IMETH = l.Substring(38, 6).Trim(),
                                        IRAMT = l.Substring(44, 6).Trim(),
                                        IREFF = l.Substring(50).Trim()
                                    };
                                    dictIR.Add(N, oIR);
                                    break;
                                case "NI":
                                    N = int.Parse(l.Substring(0, 2).Trim());
                                    OBJ.NI oNI = new OBJ.NI
                                    {
                                        //N = int.Parse(l.Substring(0, 2).Trim()),
                                        NMDEP = l.Substring(14, 6).Trim(),
                                        NMTHR = l.Substring(20, 6).Trim(),
                                        NAMNT = l.Substring(26, 6).Trim(),
                                        NCODE = l.Substring(32, 6).Trim(),
                                        NAOFF = l.Substring(38).Trim()
                                    };
                                    dictNI.Add(N, oNI);
                                    break;
                                case "RE":
                                    N = int.Parse(l.Substring(0, 2).Trim());
                                    OBJ.RE oRE = new OBJ.RE
                                    {
                                        //N = int.Parse(l.Substring(0, 2).Trim()),
                                        RIPCN = l.Substring(14, 6).Trim(),
                                        RTIME = l.Substring(20, 6).Trim(),
                                        RIDEP = l.Substring(26).Trim()
                                    };
                                    dictRE.Add(N, oRE);
                                    break;
                                case "HA":
                                    N = int.Parse(l.Substring(0, 2).Trim());
                                    OBJ.HA oHA = new OBJ.HA
                                    {
                                        //N = int.Parse(l.Substring(0, 2).Trim()),
                                        HFRST = l.Substring(14, 6).Trim(),
                                        HLAST = l.Substring(20, 6).Trim(),
                                        HPCNP = l.Substring(26, 6).Trim(),
                                        HPCNR = l.Substring(32).Trim()
                                    };
                                    dictHA.Add(N, oHA);
                                    break;
                                case "":
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }

                Dictionary<int, OBJ.SIMULATION> objs = new Dictionary<int, OBJ.SIMULATION>();
                foreach (int k in dictGE.Keys)
                {
                    OBJ.SIM oSIM = new OBJ.SIM
                    {
                        GE = dictGE[k],
                        OP = dictOP[k],
                        MA = dictMA[k],
                        ME = dictME[k],
                        OU = dictOU[k]
                    };

                    OBJ.AUTO oAUTO = new OBJ.AUTO
                    {
                        PL = dictPL[k],
                        IR = dictIR[k],
                        NI = dictNI[k],
                        RE = dictRE[k],
                        HA = dictHA[k]
                    };

                    OBJ.SIMULATION obj = new OBJ.SIMULATION
                    {
                        N = k,
                        SIM = oSIM,
                        AUTO = oAUTO
                    };
                    objs.Add(obj.N, obj);
                }
                return objs;
            }
        }

        public static OBJ.RootX FileX2ObjectX(string fileX)
        {
            OBJ.RootX root = new OBJ.RootX();
            //try
            //{
            using (StreamReader rd = new StreamReader(fileX))
            {
                string line;
                List<string> lines;
                Dictionary<string, List<string>> xDict = new Dictionary<string, List<string>>();

                string header = string.Empty;

                while ((line = rd.ReadLine()) != null)
                {
                    if (line.Trim().Length > 0)
                    {
                        if (line.Trim().Length >= 1 && line.Substring(0, 1) == "*")
                        {

                            //*EXP.DETAILS
                            if (line.ToUpper().Contains("*EXP.DETAILS"))
                            {
                                header = "DETAILS";
                                lines = new List<string>();
                                lines.Add(line.Substring(13).Trim());
                                xDict.Add(header, lines);
                            }
                            //*GENERAL
                            if (line.ToUpper().Contains("*GENERAL")) { header = "GENERAL"; xDict.Add(header, new List<string>()); }

                            //*TREATMENTS
                            if (line.ToUpper().Contains("*TREATMENTS")) { header = "TREATMENTS"; xDict.Add(header, new List<string>()); }

                            //*CULTIVARS
                            if (line.ToUpper().Contains("*CULTIVARS")) { header = "CULTIVARS"; xDict.Add(header, new List<string>()); }

                            //*FIELDS
                            if (line.ToUpper().Contains("*FIELDS")) { header = "FIELDS"; xDict.Add(header, new List<string>()); }

                            //*SOIL ANALYSIS
                            if (line.ToUpper().Contains("*SOIL")) { header = "SOIL"; xDict.Add(header, new List<string>()); }

                            //*INITIAL CONDITIONS
                            if (line.ToUpper().Contains("*INITIAL CONDITIONS")) { header = "ICONDITIONS"; xDict.Add(header, new List<string>()); }

                            //*PLANTING DETAILS
                            if (line.ToUpper().Contains("*PLANTING DETAILS")) { header = "PLANTING"; xDict.Add(header, new List<string>()); }

                            //*IRRIGATION AND WATER MANAGEMENT
                            if (line.ToUpper().Contains("*IRRIGATION")) { header = "IRRIGATION"; xDict.Add(header, new List<string>()); }

                            //*FERTILIZERS
                            if (line.ToUpper().Contains("*FERTILIZERS")) { header = "FERTILIZERS"; xDict.Add(header, new List<string>()); }

                            //*RESIDUES
                            if (line.ToUpper().Contains("*RESIDUES")) { header = "RESIDUES"; xDict.Add(header, new List<string>()); }

                            //*CHEMICAL
                            if (line.ToUpper().Contains("*CHEMICAL")) { header = "CHEMICAL"; xDict.Add(header, new List<string>()); }

                            //*TILLAGE
                            if (line.ToUpper().Contains("*TILLAGE")) { header = "TILLAGE"; xDict.Add(header, new List<string>()); }

                            //*ENVIRONMENT
                            if (line.ToUpper().Contains("*ENVIRONMENT")) { header = "ENVIRONMENT"; xDict.Add(header, new List<string>()); }

                            //*HARVEST
                            if (line.ToUpper().Contains("*HARVEST")) { header = "HARVEST"; xDict.Add(header, new List<string>()); }

                            //*SIMULATION
                            if (line.ToUpper().Contains("*SIMULATION")) { header = "SIMULATION"; xDict.Add(header, new List<string>()); }
                        }
                        else
                        {
                            List<string> sectionLines = xDict[header];
                            sectionLines.Add(line);
                            xDict.Remove(header);
                            xDict.Add(header, sectionLines);
                        }
                    }
                }

                foreach (string key in xDict.Keys)
                {
                    lines = xDict[key];
                    switch (key)
                    {
                        case "DETAILS":
                            root.EXPDETAIL = lines[0];
                            break;
                        case "GENERAL":
                            root.GENERAL = READ.readGENERAL(lines);
                            break;
                        case "TREATMENTS":
                            root.TREATMENTS = READ.readTREATMENT(lines);
                            break;
                        case "CULTIVARS":
                            root.CULTIVARS = READ.readCULTIVAR(lines);
                            break;
                        case "FIELDS":
                            root.FIELDS = READ.readFIELD(lines);
                            break;
                        case "SOIL":
                            root.SOIL = READ.readSOIL(lines);
                            break;
                        case "ICONDITIONS":
                            root.ICONDITIONS = READ.readICONDITION(lines);
                            break;
                        case "PLANTING":
                            root.PLANTING = READ.readPLANTING(lines);
                            break;
                        case "IRRIGATION":
                            root.IRRIGATION = READ.readIRRIGATION(lines);
                            break;
                        case "FERTILIZERS":
                            root.FERTILIZERS = READ.readFERTILIZER(lines);
                            break;
                        case "RESIDUES":
                            root.RESIDUES = READ.readRESIDUE(lines);
                            break;
                        case "CHEMICAL":
                            root.CHEMICAL = READ.readCHEMICAL(lines);
                            break;
                        case "TILLAGE":
                            root.TILLAGE = READ.readTILLAGE(lines);
                            break;
                        case "ENVIRONMENT":
                            root.ENVIRONMENT = READ.readENVIRONMENT(lines);
                            break;
                        case "HARVEST":
                            root.HARVEST = READ.readHARVEST(lines);
                            break;
                        case "SIMULATION":
                            root.SIMULATION = READ.readSIMULATION(lines);
                            break;
                        default:
                            break;
                    }
                }
            }
            return root;
        }
    }
}
