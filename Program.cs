public class KodePos
{
    public enum Kelurahan {Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja};
    public static int getKodePos(Kelurahan KELURAHAN)
    {
        int[] kodepos = { 40266, 40287, 40256, 40287, 40286, 40272, 40274, 40273 };
        return kodepos[(int)KELURAHAN];
    }
}

public class DoorMachine
{
    enum state {Terkunci, Terbuka};
    public static void Main(string[] args)
    {
        Console.WriteLine("Kelurahan " + KodePos.Kelurahan.Batununggal + " KodePos " + KodePos.getKodePos(KodePos.Kelurahan.Batununggal));
        Console.WriteLine("Kode Perintah : KunciPintu, BukaPintu");
        
        state KondisiPintu = state.Terkunci;
        string Perintah = "KunciPintu";
        
        while (Perintah == "KunciPintu" || Perintah == "BukaPintu")
        {
            Console.WriteLine(KondisiPintu);
            Console.Write("Masukkan Perintah : ");
            Perintah = Console.ReadLine();
            if (Perintah == "BukaPintu")
            {
                KondisiPintu = state.Terbuka;
            }
            else if (Perintah == "KunciPintu")
            {
                KondisiPintu = state.Terkunci;
            }
        }
    } 
    
}