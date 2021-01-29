using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Autolib.Models
{
    public class AutolibContext
    {
        public string ConnectionString { get; set; }

        public AutolibContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private MySqlConnection getConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Client> getAllClients()
        {
            try
            {
                List<Client> list = new List<Client>();
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from client", conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Client()
                            {
                                IdClient = Convert.ToInt32(reader["idClient"]),
                                Nom = reader["nom"].ToString(),
                                Prenom = reader["prenom"].ToString(),
                                Date_naissance = reader["date_naissance"].ToString()
                            });
                        }
                    }
                }

                return list;
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
        }

        public Client getUnClient(int idClient)
        {
            try
            {
                Client unClient = null;
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from client where idClient=" + idClient, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            unClient = new Client()
                            {
                                IdClient = Convert.ToInt32(reader["idClient"]),
                                Nom = reader["nom"].ToString(),
                                Prenom = reader["prenom"].ToString(),
                                Date_naissance = reader["date_naissance"].ToString(),
                                Password = reader["password"].ToString(),
                            };
                        }
                    }
                }
                return unClient;
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }

        public Type_Vehicule getUnType(int idType)
        {
            try
            {
                
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            Type_Vehicule unType = null;
            using (MySqlConnection conn = this.getConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Type_vehicule where idType_vehicule=" + idType, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        unType = new Type_Vehicule()
                        {
                            IdType = Convert.ToInt32(reader["idType_vehicule"]),
                            Categorie = reader["categorie"].ToString(),
                            Type_vehicule = reader["type_vehicule"].ToString(),
                        };
                    }
                }
            }

            return unType;
        }

        public Borne getBorneVehicule(int idVehicule)
        {
            try
            {
                
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            Borne uneBorne = null;
            using (MySqlConnection conn = this.getConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Borne where idVehicule=" + idVehicule, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        uneBorne = new Borne()
                        {
                            IdBorne = Convert.ToInt32(reader["idBorne"]),
                            EtatBorne = Convert.ToBoolean(reader["EtatBorne"].ToString()),
                            station = Convert.ToInt32(reader["station"].ToString()),
                            laStation = getStationById(Convert.ToInt32(reader["station"]))
                        };
                    }
                }
            }

            return uneBorne;
        }

        public Station getStationById(int idStation)
        {
            try
            {
                Station uneStation = null;
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from Station where idStation=" + idStation, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            uneStation = new Station()
                            {
                                idStation = Convert.ToInt32(reader["idStation"]),
                                Latitude = Convert.ToDecimal(reader["latitude"]),
                                Longitude = Convert.ToDecimal(reader["longitude"]),
                                adresse = reader["adresse"].ToString(),
                                numero = Convert.ToInt32(reader["numero"]),
                                ville = reader["ville"].ToString(),
                                code_postal = Convert.ToInt32(reader["code_postal"]),
                                nbVoituresLibres = getLesVehiculesByIdStation(Convert.ToInt32(reader["idStation"])).Count
                            };
                        }
                    }
                }

                return uneStation;
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }
        

        public Vehicule getUnVehicule(int idVehicule)
        {
            try
            {
                Vehicule unVehicule = null;
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from Vehicule where idVehicule=" + idVehicule, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            unVehicule = new Vehicule()
                            {
                                IdVehicule = Convert.ToInt32(reader["idVehicule"]),
                                RFID = Convert.ToInt32(reader["RFID"]),
                                EtatBatterie = Convert.ToInt32(reader["etatBatterie"]),
                                Disponibilite = reader["Disponibilite"].ToString(),
                                Latitude = Convert.ToDecimal(reader["latitude"]),
                                Longitude = Convert.ToDecimal(reader["longitude"]),
                                Type = getUnType(Convert.ToInt32(reader["type_vehicule"])),
                                laBorne = getBorneVehicule(Convert.ToInt32(reader["idVehicule"])),
                            };
                        }
                    }
                }

                return unVehicule;
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }

        public List<Vehicule> getLesVehiculesByIdStation(int idStation)
        {
            try
            {
                List<Vehicule> list = new List<Vehicule>();
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from Vehicule V JOIN borne B on V.idVehicule = b.idVehicule WHERE disponibilite='libre' AND station=" + idStation, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Vehicule()
                            {
                                IdVehicule = Convert.ToInt32(reader["idVehicule"]),
                                RFID = Convert.ToInt32(reader["RFID"]),
                                EtatBatterie = Convert.ToInt32(reader["etatBatterie"]),
                                Disponibilite = reader["Disponibilite"].ToString(),
                                Latitude = Convert.ToDecimal(reader["latitude"]),
                                Longitude = Convert.ToDecimal(reader["longitude"]),
                                Type = getUnType(Convert.ToInt32(reader["type_vehicule"])),
                                laBorne = getBorneVehicule(Convert.ToInt32(reader["idVehicule"]))
                            });
                        }
                    }
                }

                return list;
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }

        public int getNbVoituresLibresByIdStation(int idStation)
        {
            try
            {
                int nb = 0;
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select COUNT(*) as 'nb' from borne b JOIN Vehicule V on B.idVehicule = V.idVehicule WHERE Disponibilite='LIBRE' AND station="+idStation, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nb = Convert.ToInt32(reader["nb"]);
                        }
                    }
                }

                return nb;
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }
        
        public int getNbVoiturestotByIdStation(int idStation)
        {
            try
            {
                int nb = 0;
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select COUNT(*) as 'nb' from borne WHERE station="+idStation, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nb = Convert.ToInt32(reader["nb"]);
                        }
                    }
                }

                return nb;
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }

        public List<Station> getLesStations()
        {
            try
            {
                List<Station> list = new List<Station>();
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from Station", conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Station()
                            {
                                idStation = Convert.ToInt32(reader["idStation"]),
                                Latitude = Convert.ToDecimal(reader["latitude"]),
                                Longitude = Convert.ToDecimal(reader["longitude"]),
                                adresse = reader["adresse"].ToString(),
                                numero = Convert.ToInt32(reader["numero"]),
                                ville = reader["ville"].ToString(),
                                code_postal = Convert.ToInt32(reader["code_postal"]),
                                nbVoituresLibres = getNbVoituresLibresByIdStation(Convert.ToInt32(reader["idStation"])),
                                nbPlaces = getNbVoiturestotByIdStation(Convert.ToInt32(reader["idStation"])),
                            });
                        }
                    }
                }

                return list;
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }

        public void updateInfoClient(int idClient, string nom, string prenom)
        {
            try
            {
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE client SET nom='"+nom+"', prenom='"+prenom+"' WHERE idClient=" + idClient, conn);
                    cmd.ExecuteReader();
                } 
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }

        public void insertClient(string nom, string prenom, string naissance, string mdpHash)
        {
            try
            {
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        $"INSERT INTO client(nom, prenom, date_naissance, password) VALUES ('{nom}', '{prenom}', '{naissance}', '{mdpHash}')", conn);
                    cmd.ExecuteReader();
                }
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }

        public void reserver(int idVehicule, int idClient, string dateReservation)
        {
            try
            {
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        $"INSERT INTO Reservation(vehicule, client, date_reservation) VALUES ('{idVehicule}', '{idClient}', '{dateReservation}')", conn);
                    cmd.ExecuteReader();
                } 
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }

        public void changeEtatVehicule(int idVehicule, string status)
        {
            try
            {
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        $"UPDATE Vehicule SET Disponibilite='{status}' WHERE idVehicule={idVehicule}", conn);
                    cmd.ExecuteReader();
                }
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }

        public List<Reservation> GetReservationByUser(int idClient)
        {
            try
            {
                List<Reservation> list = new List<Reservation>();
                using (MySqlConnection conn = this.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from RESERVATION WHERE client="+idClient, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Reservation()
                            {
                                Vehicule = Convert.ToInt32(reader["vehicule"]),
                                Client = Convert.ToInt32(reader["client"]),
                                Date_reservation = reader["date_reservation"].ToString(),
                                Date_echeance = reader["date_echeance"].ToString(),
                                leVehicule = getUnVehicule(Convert.ToInt32(reader["vehicule"]))
                            });
                        }
                    }
                }

                return list;
            }
            catch (MySqlException erreur)
            {
                throw new Exception(erreur.Message, erreur.InnerException);
            }
            
        }
    }
}