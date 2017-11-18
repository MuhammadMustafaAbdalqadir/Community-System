using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;


namespace ConsoleApplication2{

    public class commonVariabes{
        public string name, religion, sex, job, status, date, salary, education , path, pass , id , path_;
    }




    public class admin : commonVariabes{
        public admin(string Name, string Pass){
            path = Program.GP() + @"\Admins";
            pass = Program.Enc(Pass); path += @"\"; path += Name; path += ".txt";
            File.Create(path).Close();
            File.WriteAllText(path, pass);
        }
    }




    public class citizen : commonVariabes{


        public static string p__ = Program.GP() + @"\Statics" + @"\";
        static long ID = long.Parse(Program.Dec(File.ReadAllText(p__+"n.txt")));


        public citizen(string Name, string Sex, 
            string Religion, string Status, 
            string Education, string Job, 
            string Salary){

                if (Sex == "m"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "m.txt"))); temp++;
                    File.WriteAllText(p__ + "m.txt", Program.Enc(temp.ToString()));
                }

                if (Sex == "f"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "f.txt"))); temp++;
                    File.WriteAllText(p__ + "f.txt", Program.Enc(temp.ToString()));
                }

                if (Sex == "other"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "s_ot.txt"))); temp++;
                    File.WriteAllText(p__ + "s_ot.txt", Program.Enc(temp.ToString()));
                }

                if (Religion == "jewish"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "je.txt"))); temp++;
                    File.WriteAllText(p__ + "je.txt", Program.Enc(temp.ToString()));
                }

                if (Religion == "christian"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "ch.txt"))); temp++;
                    File.WriteAllText(p__ + "ch.txt", Program.Enc(temp.ToString()));
                }

                if (Religion == "muslim"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "mu.txt"))); temp++;
                    File.WriteAllText(p__ + "mu.txt", Program.Enc(temp.ToString()));
                }

                if (Religion == "other"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "r_ot.txt"))); temp++;
                    File.WriteAllText(p__ + "r_ot.txt", Program.Enc(temp.ToString()));
                }

                if (Status == "single"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "si.txt"))); temp++;
                    File.WriteAllText(p__ + "si.txt", Program.Enc(temp.ToString()));
                }

                if (Education == "n"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "e_0.txt"))); temp++;
                    File.WriteAllText(p__ + "e_0.txt", Program.Enc(temp.ToString()));
                }

                if (Job == "nothing"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "jo_0.txt"))); temp++;
                    File.WriteAllText(p__ + "jo_0.txt", Program.Enc(temp.ToString()));
                }


            name = Program.Enc(Name); sex = Program.Enc(Sex); religion = Program.Enc(Religion); education = Program.Enc(Education);
            status = Program.Enc(Status); job = Program.Enc(Job); ID++; date = Program.Enc(DateTime.Now.ToString()); salary = Program.Enc(Salary);
            path = Program.GP() + @"\Citizens"; path += @"\"; path += ID.ToString(); path += ".txt"; id = Program.Enc(ID.ToString());
            string[] grid = { id, name, date, sex, religion, status, education, job, salary };
            path_ = Program.GP() + @"\Security"; path_ += @"\"; path_ += ID.ToString(); path_ += ".txt";
            File.Create(path).Close(); File.Create(path_).Close();
            File.WriteAllLines(path, grid);
            File.WriteAllText(p__ + "n.txt", Program.Enc(ID.ToString())); ///////
            Program.CL(); Program.anime("Citizen Added Successfully! His ID Is "); Program._((int)ID); Program.anime("\n"); Program.Sleep(3000); Program.CL();
        }

        public citizen(string Name, string Sex, 
            string Religion, string Status, 
            string Education, string Job, 
            string Salary , 
            string born){

                
                

                if (Sex == "m"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "m.txt"))); temp++;
                    File.WriteAllText(p__ + "m.txt",Program.Enc(temp.ToString()));
                }

                if (Sex == "f"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "f.txt"))); temp++;
                    File.WriteAllText(p__ + "f.txt", Program.Enc(temp.ToString()));
                }

                if (Sex == "other"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "s_ot.txt"))); temp++;
                    File.WriteAllText(p__ + "s_ot.txt", Program.Enc(temp.ToString()));
                }

                if (Religion == "jewish"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "je.txt"))); temp++;
                    File.WriteAllText(p__ + "je.txt", Program.Enc(temp.ToString()));
                }

                if (Religion == "christian"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "ch.txt"))); temp++;
                    File.WriteAllText(p__ + "ch.txt", Program.Enc(temp.ToString()));
                }

                if (Religion == "muslim"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "mu.txt"))); temp++;
                    File.WriteAllText(p__ + "mu.txt", Program.Enc(temp.ToString()));
                }

                if (Religion == "other"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "r_ot.txt"))); temp++;
                    File.WriteAllText(p__ + "r_ot.txt", Program.Enc(temp.ToString()));
                }

                if (Status == "single"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "si.txt"))); temp++;
                    File.WriteAllText(p__ + "si.txt", Program.Enc(temp.ToString()));
                }

                if (Status == "married"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "ma.txt"))); temp++;
                    File.WriteAllText(p__ + "ma.txt", Program.Enc(temp.ToString()));
                }

                if (Status == "in relationship"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "in.txt"))); temp++;
                    File.WriteAllText(p__ + "in.txt", Program.Enc(temp.ToString()));
                }

                if (Education == "y"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "e_1.txt"))); temp++;
                    File.WriteAllText(p__ + "e_1.txt", Program.Enc(temp.ToString()));
                }

                if (Education == "n"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "e_0.txt"))); temp++;
                    File.WriteAllText(p__ + "e_0.txt", Program.Enc(temp.ToString()));
                }

                if (Job == "nothing"){
                    int temp = int.Parse(Program.Dec(File.ReadAllText(p__ + "jo_0.txt"))); temp++;
                    File.WriteAllText(p__ + "jo_0.txt", Program.Enc(temp.ToString()));
                }


            name = Program.Enc(Name); sex = Program.Enc(Sex); religion = Program.Enc(Religion); education = Program.Enc(Education);
            status = Program.Enc(Status); job = Program.Enc(Job); ID++; date = Program.Enc(born); salary = Program.Enc(Salary);
            path = Program.GP() + @"\Citizens"; path += @"\"; path += ID.ToString(); path += ".txt"; id = Program.Enc(ID.ToString());
            string[] grid = { id , name, date, sex, religion, status, education, job, salary };
            path_ = Program.GP() + @"\Security"; path_ += @"\"; path_ += ID.ToString(); path_ += ".txt";
            File.Create(path).Close(); File.Create(path_).Close();
            File.WriteAllLines(path, grid);
            File.WriteAllText(p__+"n.txt", Program.Enc(ID.ToString())); ///////
            Program.CL(); Program.anime("Citizen Added Successfully! His ID Is "); Program._((int)ID); Program.anime("\n"); Program.Sleep(3000); Program.CL();

        }
      //  public static void Edit_Citizen_Info(string id , string Name, 
           // string Sex, string Religion, string Status, 
           // string Education, string Job, 
           // string Salary ,
          //  string born){
            //    Name = Program.Enc(Name); Sex = Program.Enc(Sex); Religion = Program.Enc(Religion); Education = Program.Enc(Education);
            //    Status = Program.Enc(Status); Job = Program.Enc(Job); born = Program.Enc(born); Salary = Program.Enc(Salary);
           //     string path = Program.GP() + @"\Citizens"; path += @"\"; path += id; path += ".txt";
           //     string[] grid = { Program.Enc(id.ToString()), Name, born, Sex, Religion, Status, Education, Job, Salary };
          //          File.WriteAllLines(path,grid);
         //           Program.CL(); Program._("Citizen's Information Edited Successfully!\n"); Program.Sleep(2000); Program.CL();
        //}
    }








    public class security : commonVariabes{
        
        public static void SHOW_ME(string id__){

            string p = Program.GP() + @"\Citizens"; p += @"\"; p += id__; p += ".txt"; // must zabtha shwya
            string[] grid = File.ReadAllLines(p);

            Program.anime("---------------------------------------\n");
            for (int i = 0; i < grid.Length; i++){
                if (i == 0) Program.anime("ID            : ");
                if (i == 1) Program.anime("Name          : ");
                if (i == 2) Program.anime("Date Of Birth : ");
                if (i == 3) Program.anime("Sex           : ");
                if (i == 4) Program.anime("Religion      : ");
                if (i == 5) Program.anime("Status        : ");
                if (i == 6) Program.anime("Educated      : ");
                if (i == 7) Program.anime("Job           : ");
                if (i == 8) Program.anime("Salary        : ");
                Program.anime(Program.Dec(grid[i])); Program.anime("\n");
            }
            Program.anime("---------------------------------------\n");

        }

        public security(string father, string child){

            path = Program.GP() + @"\Security"; path += @"\"; path += father; path += ".txt"; child = Program.Enc(child);
            child += Environment.NewLine; File.AppendAllText(path, child);
            Program.CL(); Program.anime("Successfully Added ...\n"); Program.Sleep(2000); 

        }

        public static void GET_DIRECT_PPL(string id){

            string p = Program.GP() + @"\Security"; p += @"\"; p += id; p += ".txt";
            string[] read = File.ReadAllLines(p); Program.anime("The Direct Relations ("); Program._(read.Length); Program.anime(")\n\n");
            for (int i = 0; i < read.Length; i++) read[i] = Program.Dec(read[i]);
            for (int i = 0; i < read.Length; i++){
                SHOW_ME(read[i]);
            }

        }

        public static void GET_ALL_FUCKERS_HERE(string id){

            Hashtable ht = new Hashtable();
            ht.Add(id, true); Program.anime("The Direct And Non Direct Relations \n\n");
            Queue <string> q = new Queue <string>();
            q.Enqueue(id);

            while (q.Count > 0){

                string u = q.Dequeue();
                if (u != id) SHOW_ME(u);
                string p = Program.GP() + @"\Security"; p += @"\"; p += u; p += ".txt";
                string[] to = File.ReadAllLines(p);

                for (int i = 0; i < to.Length; i++) to[i] = Program.Dec(to[i]);
                for (int i = 0; i < to.Length; i++){
                    if (!ht.ContainsKey(to[i])){
                        q.Enqueue(to[i]);
                        ht.Add(to[i], true);
                    }
                }

            }

        }


    }






    
    class Program {
        static void Main(string[] args){



            CHANGE__();
            string path = GP();
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            if (!Directory.Exists(path + @"\Admins")) Directory.CreateDirectory(path + @"\Admins");
            if (!Directory.Exists(path + @"\Citizens")) Directory.CreateDirectory(path + @"\Citizens");
            if (!Directory.Exists(path + @"\Security")) Directory.CreateDirectory(path + @"\Security");
            if (!Directory.Exists(path + @"\Statics")) Directory.CreateDirectory(path + @"\Statics");
            string p__ = Program.GP() + @"\Statics"; p__ += @"\"; // p__ += ; p__ += ".txt";
            if (!File.Exists(p__ + "s_ot.txt")){ File.Create(p__ + "s_ot.txt").Close(); File.WriteAllText(p__ +  "s_ot.txt", "-");}
            if (!File.Exists(p__ + "m.txt")){ File.Create(p__ + "m.txt").Close();File.WriteAllText(p__ + "m.txt" , "-");}
            if (!File.Exists(p__ + "f.txt")){ File.Create(p__ + "f.txt").Close();File.WriteAllText(p__ + "f.txt" , "-");}
            if (!File.Exists(p__ + "mu.txt")){ File.Create(p__ + "mu.txt").Close();File.WriteAllText(p__ + "mu.txt" , "-");}
            if (!File.Exists(p__ + "ch.txt")){ File.Create(p__ + "ch.txt").Close();File.WriteAllText(p__ + "ch.txt" , "-");}
            if (!File.Exists(p__ + "je.txt")){ File.Create(p__ + "je.txt").Close();File.WriteAllText(p__ + "je.txt" , "-");}
            if (!File.Exists(p__ + "r_ot.txt")){ File.Create(p__ + "r_ot.txt").Close();File.WriteAllText(p__ + "r_ot.txt" , "-");}
            if (!File.Exists(p__ + "si.txt")){ File.Create(p__ + "si.txt").Close();File.WriteAllText(p__ + "si.txt" , "-");}
            if (!File.Exists(p__ + "ma.txt")){ File.Create(p__ + "ma.txt").Close();File.WriteAllText(p__ + "ma.txt" , "-");}
            if (!File.Exists(p__ + "in.txt")){ File.Create(p__ + "in.txt").Close();File.WriteAllText(p__ + "in.txt" , "-");}
            if (!File.Exists(p__ + "e_1.txt")){ File.Create(p__ + "e_1.txt").Close();File.WriteAllText(p__ + "e_1.txt" , "-");}
            if (!File.Exists(p__ + "e_0.txt")){ File.Create(p__ + "e_0.txt").Close();File.WriteAllText(p__ + "e_0.txt" , "-");}
            if (!File.Exists(p__ + "n.txt")){ File.Create(p__ + "n.txt").Close();File.WriteAllText(p__ + "n.txt" , "-");}
            if (!File.Exists(p__ + "jo_0.txt")) { File.Create(p__ + "jo_0.txt").Close(); File.WriteAllText(p__ + "jo_0.txt", "-"); }



            anime("Please Enter The Serial Number ...\n");
            string t = ReadPassword();


            while (t != "666"){

                CL();
                anime("Wrong Number , Please Enter The Serial Number ...\n");
                t = ReadPassword();
            }

            CL(); anime("Welcome ... "); Sleep(1100); CL();
            anime("1.Login\n2.Create New Admin Account\n\n\n\n\n\n\nChoose ---> "); int choise = Ri(); CL();

            if (choise == 2){

                string i, p;
                anime("Write Your Name : "); i = Rs();
                anime("Write Your Password : "); p = ReadPassword();
                admin NEW_ADMIN = new admin(i, p);
                CL(); anime("Account Created ..."); Sleep(1100); CL();

            }

            while (true){

                string chk1, chk2;
                anime("UserName : "); chk1 = Rs();
                anime("PassWord : "); chk2 = ReadPassword();
                chk2 = Enc(chk2);
                if (!File.Exists(path + @"\Admins" + @"\" + chk1 + ".txt")) { anime("Wrond UserName ..."); Sleep(1100); CL(); continue; }
                string words = File.ReadAllText(path + @"\Admins" + @"\" + chk1 + ".txt");

                if (words == chk2){
                    CL(); anime("Welcome "); anime(chk1); anime(" ..."); Sleep(1100); CL(); break;
                }

                else{
                    anime("Wrond Password ..."); Sleep(1100); CL(); continue;
                }
            }

            while (true){

                anime("Welcome To The Main Menu ...\n\n");
                anime("1.Citizens\n"); anime("2.Security\n");
                anime("3.Statics\n"); anime("4.Exit\n\n\n\n\n\n\nChoose ---> ");
                int choi = Ri(); CL();

                if (choi == 1){

                    while (true){

                        anime("Citizens Menu ...\n\n");
                        anime("1.Add Existed Citizen To DataCenter\n");
                        anime("2.Add New Born To DataCenter\n");
                        anime("3.Return To Main Menu\n\n\n\n\n\n\nChoose ---> ");
                        int click = Ri(); CL();
                        if (click == 1){

                            string name, date, sex, rel, stat, edu, job, salary = "0";
                            anime("Name : "); name = Rs();
                            anime("Date Of Birth (EX: "); anime(DateTime.Now.ToString()); anime(") : "); date = Rs();
                            anime("Sex (EX: m/f/other) : "); sex = Rs();
                            anime("Religion (EX: jewish/christian/muslim/other) : "); rel = Rs();
                            anime("Status (EX: single/married/in_relationship) : "); stat = Rs();
                            anime("Educated ?(y/n) : "); edu = Rs();
                            anime("Job (EX: -you can add any job-/nothing) : "); job = Rs();
                            if (job != "nothing") { anime("Salary : "); salary = Rs(); }
                            citizen cannibalsgod = new citizen(name, sex, rel, stat, edu, job, salary, date);
                            continue;
                        }

                        if (click == 2){

                            string name, sex, rel, stat = "single", edu = "n", job = "nothing", salary = "0";
                            anime("Name : "); name = Rs();
                            //_("Date Of Birth (EX: "); _(DateTime.Now.ToString()); _(") : "); date = Rs();
                            anime("Sex (EX: m/f/other) : "); sex = Rs();
                            anime("Religion (EX: jewish/christian/muslim/other) : "); rel = Rs();
                            //_("Status (EX: single/married/in_relationship) : "); stat = Rs();
                            //_("Educated ?(y/n) : "); edu = Rs();
                            //_("Job (EX: -you can add any job-/nothing) : "); job = Rs();
                            //if (job != "nothing") { _("Salary : "); salary = Rs(); }
                            citizen cannibalsgod = new citizen(name, sex, rel, stat, edu, job, salary);
                            continue;

                        }
                       // if (click == 3){
                           // _("The ID Of The Citizen : ");
                           // string id = Rs(); CL();
                           // string p = Program.GP() + @"\Citizens"; p += @"\"; p += id; p += ".txt";
                           // if (!File.Exists(p)) { Program.CL(); Program._("There Is No Citizen Have This Id.\n"); Program.Sleep(1100); Program.CL(); continue; }
                          //  string name, date, sex, rel, stat, edu, job, salary = "0";
                           // _("Name : "); name = Rs();
                           // _("Date Of Birth (EX: "); _(DateTime.Now.ToString()); _(") : "); date = Rs();
                          //  _("Sex (EX: m/f/other) : "); sex = Rs();
                          //  _("Religion (EX: jewish/christian/muslim/other) : "); rel = Rs();
                          //  _("Status (EX: single/married/in_relationship) : "); stat = Rs();
                         //   _("Educated ?(y/n) : "); edu = Rs();
                          //  _("Job (EX: -you can add any job-/nothing) : "); job = Rs();
                         //   if (job != "nothing") { _("Salary : "); salary = Rs(); }
                        //    citizen.Edit_Citizen_Info(id, name, sex, rel, stat, edu, job, salary, date);
                        //    continue;
                       // }
                       // if (click == 4) break;
                        if (click == 3) break;

                    }
                }

                if (choi == 2){
                    while (true){

                        anime("Security Menu ...\n\n");
                        anime("1.Ask For Certain Citizen's Information\n");
                        anime("2.Add A Family Member Or A Friend To Certain Citizen\n");
                        anime("3.Ask For The Citizens That Have Direct Relation With Certain Citizen\n");
                        anime("4.Ask For The Citizens That have Direct Or Non Direct Relation With Certain Citizen\n");
                        anime("5.Return To Main Menu\n\n\n\n\n\n\nChoose ---> ");
                        int kick = Ri(); CL();

                        if (kick == 1){
                            anime("The ID Of The Citizen : "); string tempo = Rs();
                            CL(); security.SHOW_ME(tempo);
                            anime("\n\nPress Enter To Back ---> "); Rs(); CL(); continue;
                        }

                        if (kick == 2){ //////////////////////////////////////////////////////////////
                            anime("The ID Of The Certain Citizen : "); string tempo = Rs();
                            CL(); string p = Program.GP() + @"\Security"; p += @"\"; p += tempo; p += ".txt";
                            if (!File.Exists(p)) { Program.CL(); Program.anime("There Is No Citizen Have This Id.\n"); Program.Sleep(1100); Program.CL(); continue; }
                            anime("The ID Of The Family Member Or The Friend You Want To Add : "); string chi = Rs();
                            p = Program.GP() + @"\Security"; p += @"\"; p += chi; p += ".txt";
                            if (!File.Exists(p)) { Program.CL(); Program.anime("There Is No Citizen Have This Id.\n"); Program.Sleep(1100); Program.CL(); continue; }
                            security canni = new security(tempo, chi); security cannii = new security(chi, tempo);
                            anime("\n\nPress Enter To Back ---> "); Rs(); CL(); continue;
                        }

                        if (kick == 3){
                            anime("The ID Of The Certain Citizen : "); string tempo = Rs();
                            CL(); string p = Program.GP() + @"\Security"; p += @"\"; p += tempo; p += ".txt";
                            if (!File.Exists(p)) { Program.CL(); Program.anime("There Is No Citizen Have This Id.\n"); Program.Sleep(1100); Program.CL(); continue; }
                            security.GET_DIRECT_PPL(tempo);
                            anime("\n\nPress Enter To Back ---> "); Rs(); CL(); continue;
                        }

                        if (kick == 4){
                            anime("The ID Of The Certain Citizen : "); string tempo = Rs();
                            CL(); string p = Program.GP() + @"\Security"; p += @"\"; p += tempo; p += ".txt";
                            if (!File.Exists(p)) { Program.CL(); Program.anime("There Is No Citizen Have This Id.\n"); Program.Sleep(1100); Program.CL(); continue; }
                            security.GET_ALL_FUCKERS_HERE(tempo);
                            anime("\n\nPress Enter To Back ---> "); Rs(); CL(); continue;
                        }

                        if (kick == 5) break;

                    }
                }
                if (choi == 3){

                    while (true){

                        anime("Statics Menu ...\n\n");
                        anime("1.The Percentages Of Genders\n");
                        anime("2.The Percentages Of Religions\n");
                        anime("3.The Percentages Of Statuses\n");
                        anime("4.The Percentages Of Education\n");
                        anime("5.The Percentage Of Unemployed\n");
                        anime("6.Return To Main Menu\n\n\n\n\n\n\nChoose ---> ");
                        int sh = Ri(); CL();
                        int N = int.Parse(Program.Dec(File.ReadAllText(p__ + "n.txt")));

                        if (sh == 1){
                            int t1 = int.Parse(Program.Dec(File.ReadAllText(p__ + "m.txt")));
                            int t2 = int.Parse(Program.Dec(File.ReadAllText(p__ + "f.txt")));
                            int t3 = int.Parse(Program.Dec(File.ReadAllText(p__ + "s_ot.txt")));
                            anime("The Percentage Of Males "); _(((double)t1 / (double)N) * (double)100); anime("%\n");
                            anime("The Percentage Of Females "); _(((double)t2 / (double)N) * (double)100); anime("%\n");
                            anime("The Percentage Of Others "); _(((double)t3 / (double)N) * (double)100); anime("%\n");
                        }

                        if (sh == 2){
                            int t1 = int.Parse(Program.Dec(File.ReadAllText(p__ + "mu.txt")));
                            int t2 = int.Parse(Program.Dec(File.ReadAllText(p__ + "ch.txt")));
                            int t3 = int.Parse(Program.Dec(File.ReadAllText(p__ + "je.txt")));
                            int t4 = int.Parse(Program.Dec(File.ReadAllText(p__ + "r_ot.txt")));
                            anime("The Percentage Of Muslems "); _(((double)t1 / (double)N) * (double)100); anime("%\n");
                            anime("The Percentage Of Christians "); _(((double)t2 / (double)N) * (double)100); anime("%\n");
                            anime("The Percentage Of Jewish "); _(((double)t3 / (double)N) * (double)100); anime("%\n");
                            anime("The Percentage Of Others "); _(((double)t4 / (double)N) * (double)100); anime("%\n");
                        }

                        if (sh == 3){
                            int t1 = int.Parse(Program.Dec(File.ReadAllText(p__ + "si.txt")));
                            int t2 = int.Parse(Program.Dec(File.ReadAllText(p__ + "ma.txt")));
                            int t3 = int.Parse(Program.Dec(File.ReadAllText(p__ + "in.txt")));
                            anime("The Percentage Of Single Citizens "); _(((double)t1 / (double)N) * (double)100); anime("%\n");
                            anime("The Percentage Of Married Citizens "); _(((double)t2 / (double)N) * (double)100); anime("%\n");
                            anime("The Percentage Of In Relatioship "); _(((double)t3 / (double)N) * (double)100); anime("%\n");
                        }

                        if (sh == 4){
                            int t1 = int.Parse(Program.Dec(File.ReadAllText(p__ + "e_1.txt")));
                            int t2 = int.Parse(Program.Dec(File.ReadAllText(p__ + "e_0.txt")));
                            anime("The Percentage Of Educated Citizens "); _(((double)t1 / (double)N) * (double)100); anime("%\n");
                            anime("The Percentage Of Ignorant Citizens "); _(((double)t2 / (double)N) * (double)100); anime("%\n");
                        }

                        if (sh == 5){
                            int t1 = int.Parse(Program.Dec(File.ReadAllText(p__ + "jo_0.txt")));
                            anime("The Percentage Of Unemployed Citizens "); _(((double)t1 / (double)N) * (double)100); anime("%\n");
                        }

                        if (sh == 6) break;

                    }
                }

                if (choi == 4) break;

            }
            







            Console.ReadLine();
        }




        public static void anime(string str){
            //CL();
            for (int i = 0; i < str.Length; i++)
            {
                Sleep(50); _(str[i]);
            }
        }


        public static string GP() { string ret = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ret += @"\ECSV1_DATA"; return ret; }

        public static string Enc(string str){
            StringBuilder sb = new StringBuilder(str); int sz = str.Length;
            for (int i = 0; i < sz; i++){
                if (i % 2 == 0){
                    sb[i] = (char)(str[i] - 3);
                }
                else {
                    sb[i] = (char)(str[i] + 2);
                }
            }
            return sb.ToString();
        }

        public static string Dec(string str){
            StringBuilder sb = new StringBuilder(str); int sz = str.Length;
            for (int i = 0; i < sz; i++){
                if (i % 2 == 0){
                    sb[i] = (char)(str[i] + 3);
                }
                else{
                    sb[i] = (char)(str[i] - 2);
                }
            }
            return sb.ToString();
        }

        public static void CL() { Console.Clear(); }

        public static int Ri() { return int.Parse(Console.ReadLine()); }

        public static string Rs() { return Console.ReadLine(); }

        public static void Sleep(int x) { System.Threading.Thread.Sleep(x); }

        public static void _(string str){
            Console.Write(str);
        }

        public static void _(char str){
            Console.Write(str);
        }

        public static void _(int s){
            Console.Write(s);
        }

        public static void _(double d){
            Console.Write(d);
        }

        public static void CHANGE__(){
            Console.BackgroundColor = ConsoleColor.DarkBlue; Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static string ReadPassword(){
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter){
                if (info.Key != ConsoleKey.Backspace){
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace){
                    if (!string.IsNullOrEmpty(password)){
                        password = password.Substring(0, password.Length - 1);
                        int pos = Console.CursorLeft;
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }
    }


    
}
