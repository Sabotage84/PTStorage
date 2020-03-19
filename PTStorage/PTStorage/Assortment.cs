using PTStorage.Equipment;
using PTStorage.Equipment.Antenna;
using PTStorage.Equipment.Cable;
using PTStorage.Equipment.Clock;
using PTStorage.Equipment.Meinberg;
using PTStorage.Equipment.Misc;
using PTStorage.Equipment.Sedov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTStorage
{
    public class Assortment
    {
        List<Server> servers;
        List<Antenna> antennas;
        List<Cable> cables;
        List<Clock> clocks;
        List<Converter> converters;
        List<Receiver> receivers;
        List<SDU> sdus;
        List<SedovServer> sedovServers;
        List<Misc> miscs;



        public Assortment()
        {
            Servers = new List<Server>();
            Antennas = new List<Antenna>();
            Cables = new List<Cable>();
            Clocks = new List<Clock>();
            Converters = new List<Converter>();
            Receivers = new List<Receiver>();
            Sdus = new List<SDU>();
            SedovServers = new List<SedovServer>();
            Miscs = new List<Misc>();

        }

        public List<Server> Servers { get => servers; set => servers = value; }
        public List<Antenna> Antennas { get => antennas; set => antennas = value; }
        public List<Cable> Cables { get => cables; set => cables = value; }
        public List<Clock> Clocks { get => clocks; set => clocks = value; }
        public List<Converter> Converters { get => converters; set => converters = value; }
        public List<Receiver> Receivers { get => receivers; set => receivers = value; }
        public List<SDU> Sdus { get => sdus; set => sdus = value; }
        public List<SedovServer> SedovServers { get => sedovServers; set => sedovServers = value; }
        public List<Misc> Miscs { get => miscs; set => miscs = value; }

        public void AddEquipment(BaseEquip eq)
        {
            if (eq is Server)
            {
                Server sv = (Server)eq;
                if (sv.PossibilityOfVerification)
                    sv.Name = PreName.USCHV + sv.Name;
                else
                    sv.Name = PreName.STV + sv.Name;
                Servers.Add(sv);
                Servers.Sort();
            }
            else if(eq is Antenna)
            {
                eq.Name = PreName.ANTENNA + eq.Name;
                Antennas.Add((Antenna)eq);
                Antennas.Sort();
            }
            else if (eq is Cable)
            {
                eq.Name = PreName.CABLE + eq.Name;
                Cables.Add((Cable)eq);
                Cables.Sort();
            }
            else if(eq is Clock)
            {
                eq.Name = PreName.CLOCK + eq.Name;
                Clocks.Add((Clock)eq);
                Clocks.Sort();
            }
            else if (eq is Converter)
            {
                eq.Name = PreName.SDUPlus + eq.Name;
                Converters.Add((Converter)eq);
                Converters.Sort();
            }
            else if (eq is Receiver)
            {
                eq.Name = PreName.RECEIVER + eq.Name;
                Receivers.Add((Receiver)eq);
                Receivers.Sort();
            }
            else if(eq is SDU)
            {
                eq.Name = PreName.SDUPlus + eq.Name;
                Sdus.Add((SDU)eq);
                Sdus.Sort();
            }
            else if (eq is SedovServer)
            {
                eq.Name = PreName.STV + eq.Name;
                SedovServers.Add((SedovServer)eq);
                SedovServers.Sort();
            }
            else
            {
                Miscs.Add((Misc)eq);
                Miscs.Sort();
            }

        }

        public List<BaseEquip> FindByName(string findStr)
        {
            List<BaseEquip> res = new List<BaseEquip>();
            res.AddRange(Servers.FindAll((x) => x.Name.Contains(findStr)));
            res.AddRange(Antennas.FindAll((x) => x.Name.Contains(findStr)));
            res.AddRange(Cables.FindAll((x) => x.Name.Contains(findStr)));
            res.AddRange(Clocks.FindAll((x) => x.Name.Contains(findStr)));
            res.AddRange(Converters.FindAll((x) => x.Name.Contains(findStr)));
            res.AddRange(Receivers.FindAll((x) => x.Name.Contains(findStr)));
            res.AddRange(Sdus.FindAll((x) => x.Name.Contains(findStr)));
            res.AddRange(SedovServers.FindAll((x) => x.Name.Contains(findStr)));
            res.AddRange(Miscs.FindAll((x) => x.Name.Contains(findStr)));
            return res;
        }

        public List<BaseEquip> FindByDescription(string findStr)
        {
            List<BaseEquip> res = new List<BaseEquip>();
            res.AddRange(Servers.FindAll((x) => x.Description.Contains(findStr)));
            res.AddRange(Antennas.FindAll((x) => x.Description.Contains(findStr)));
            res.AddRange(Cables.FindAll((x) => x.Description.Contains(findStr)));
            res.AddRange(Clocks.FindAll((x) => x.Description.Contains(findStr)));
            res.AddRange(Converters.FindAll((x) => x.Description.Contains(findStr)));
            res.AddRange(Receivers.FindAll((x) => x.Description.Contains(findStr)));
            res.AddRange(Sdus.FindAll((x) => x.Description.Contains(findStr)));
            res.AddRange(SedovServers.FindAll((x) => x.Description.Contains(findStr)));
            res.AddRange(Miscs.FindAll((x) => x.Description.Contains(findStr)));
            return res;
        }

        public List<BaseEquip> FindAny(string findStr)
        {
            List<BaseEquip> res = new List<BaseEquip>();
            res.AddRange(FindByName(findStr));
            res.AddRange(FindByDescription(findStr));
            return res;
        }

    }
}
