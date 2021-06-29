
namespace AntonysApps.HouseShare
{
    public class queries
    {
        public static string getHousesQ = @"
                                select HID, HouseName, PaymentConf from Houses
                                ";

        public static string getHouseDetailsQ = @"
                                select HouseName, HMID 
                                from houses, housemates
                                where
                                houses.HID = @houseID
                                AND
                                houses.HID = housemates.HID
                                ";


        public static string getHouseBalsQ = @"SELECT housemates.HMID, housemates.FName, SUM(transin.Amount) AS TotalIn
                                FROM housemates, houses, transin
                                where
                                (
                                housemates.HMID = transin.HMID
                                AND
                                housemates.HID = houses.HID
                                AND
                                houses.HID = @houseID
                                )
                                GROUP BY housemates.HMID, housemates.FName
                                                                ";

        public static string enterPayInQ = @"
                               insert into transin (HMID, Amount, DT)
                                        values (@HMID, @payInAmount, @dt)
                                ";


        public static string enterPayOutQ = @"
                               insert into transout (HID, BillType, Amount, Notes, DT)
                                        values (@HID, @billType, @payOutAmount, @notes, @dt)
                                ";

        public static string getBillTypesQ = @"
                                select billtypeID, description from billtypes
                                ";

        public static string getTotalInQ = @"SELECT SUM(transin.Amount) AS TotalIn
                                FROM transin
                                where
                                HMID in
                                (SELECT HMID from housemates
                                where HID = @houseID)";

        public static string getTotalOutQ = @"SELECT SUM(transout.Amount) AS TotalOut
                                    FROM transout
                                    where HID = @houseID";


        public static string getPaymentsInQ = @"
                                SELECT TransinID as TransactionID, HMID as HouseMate, Amount, DT as PaymentDate
                                from transin
                                where
                                SystemGenerated = 0 
                                AND
                                HMID in
                                (select HMID
                                from housemates, houses
                                where
                                housemates.HID = houses.HID
                                AND 
                                houses.HID = @houseID)
                                ";


        public static string getPaymentsOutQ = @"
                                    SELECT TransoutID as TransactionID, HID as HouseID, Amount, Notes as Notes, DT as PaymentDate
                                from transout
                                where
                                SystemGenerated = 0
                                AND
                                HID = @houseID
                                ";

        public static string deleteRecordInQ = @"
                                delete from transin
                                where TransinID = @transID
                                ";

        public static string deleteRecordOutQ = @"
                                delete from transout
                                where TransoutID = @transID
                                ";

        public static string renameHouseQ = @"
                               UPDATE houses
                               SET HouseName = @newHouseName
                               WHERE HID = @idPassed
                                ";

        public static string renameBillTypeQ = @"
                               UPDATE billTypes
                               SET description = @newBillTypeName
                               WHERE billTypeID = @idPassed
                                ";

        public static string renameHouseMateQ = @"
                               UPDATE housemates
                               SET Fname = @newHouseMateName
                               WHERE HMID = @idPassed
                                ";

        public static string getHouseMatesQ = @"
                                select HMID, Fname 
                                from houses, housemates
                                where
                                houses.HID = @houseID
                                AND
                                houses.HID = housemates.HID
                                ";

        public static string addNewHouse1Q = @"
                                insert into houses (HouseName)
                                values (@houseNameToAdd)
                                ";

        public static string getNewHIDQ = @"
                                select HID 
                                from houses
                                where HouseName = @houseNameToAdd
                                ";

        public static string addNewHouseMate1Q = @"
                                insert into housemates (HID, Fname)
                                values (@newHID,@Fname) ";

        public static string addNewHouse2Q = @"          
                                insert into transout (HID, BillType, Amount, DT, SystemGenerated)
                                values (@newHID,1,0,date('now'),1)";


        public static string getNewHMIDQ = @"
                                select HMID 
                                from housemates
                                where 
                                HID = @newHID
                                AND 
                                Fname = @Fname
                                ";

        public static string addNewHouseMate2Q = @"
                                insert into transin (HMID, Amount, DT, SystemGenerated)
                                values (@newHMID,0,date('now'),1)
                                ";

        public static string addBillTypeQ = @"
                                insert into billtypes (description)
                                values (@description)
                                ";


        public static string deleteBillType1Q = @"delete from billtypes where billTypeID = @billTypeID";
        public static string deleteBillType2Q = @"delete from transout where BillType = @billTypeID";

        public static string deleteHouse1Q = @"delete from transin 
                                        where HMID in 
                                        (
                                             select HMID from housemates 
                                            where HID = @HID
                                            ) ";

        public static string deleteHouse2Q = @"delete from transout where HID = @HID";
        public static string deleteHouse3Q = @"delete from housemates where HID = @HID";
        public static string deleteHouse4Q = @"delete from houses where HID = @HID";

        public static string deleteHouseMate1Q = @"delete from transin where HMID = @HMID";
        public static string deleteHouseMate2Q = @"delete from housemates where HMID = @HMID";

        public static string getHouseSettingsQ = @"select PaymentConf from houses where HID = @HID";

        public static string updateHouseSettingsQ = @" update houses set PaymentConf = @PaymentConf 
                                                        where HID = @HID";

    }
}
