using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

#nullable disable

namespace api.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Lots

            StringBuilder stringBuilder = new StringBuilder();

            string usersSQL = @"
INSERT INTO `auction`.`users` (`Id`, `Name`, `Email`, `Password`, `Balance`) 
VALUES 
('1', '1', '1', '3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2', '491'),
('2', '2', '2', '3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2', '209'),
('3', '3', '3', '3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2', '500'),
('4', '4', '4', '3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2', '600')
;
";

            string lotsSQL = @"
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('1', 'Test', 'sunduk', '5.000000000000000000000000000000', '2025-05-23 22:00:55.667753', '2025-05-24 10:00:55.667768', '12', '1', '3', '2025-05-23 22:00:55.667733', '1');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('2', 'tapki', 'tapki', '23.000000000000000000000000000000', '2025-05-23 22:08:32.126389', '2025-05-25 01:08:32.126402', '27', '1', '4', '2025-05-23 22:08:32.126375', '1');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('3', 'kokoytoFrukt', 'kokoytoFrukt', '3.000000000000000000000000000000', '2025-05-23 22:10:48.416219', '2025-05-24 03:10:48.416219', '5', '1', '3', '2025-05-23 22:10:48.416219', '1');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('4', 'horse', 'horse', '22.000000000000000000000000000000', '2025-05-23 22:11:41.973474', '2025-05-26 04:11:41.973474', '54', '1', '2', '2025-05-23 22:11:41.973473', '1');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('5', 'piraty', 'piraty', '8.000000000000000000000000000000', '2025-05-23 22:12:24.415606', '2025-05-24 02:12:24.415606', '4', '1', '1', '2025-05-23 22:12:24.415605', '1');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('6', 'clock', 'clock clockclock', '24.000000000000000000000000000000', '2025-05-23 22:12:45.886708', '2025-05-24 22:12:45.886708', '24', '1', '1', '2025-05-23 22:12:45.886708', '1');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `PriceBet`, `UserCreatedId`, `UserBoughtId`, `UserBetId`) VALUES ('7', 'mango', 'mango mango', '8.000000000000000000000000000000', '2025-05-23 22:13:12.211473', '2025-05-22 06:13:12.211473', '8', '2', '3', '2025-05-23 22:13:12.211473', '13.000000000000000000000000000000', '1', '2', '2');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('8', 'Chaynik 1', 'Chaynik 1', '32.000000000000000000000000000000', '2025-05-23 22:14:11.580865', '2025-05-26 05:14:11.580865', '55', '1', '1', '2025-05-23 22:14:11.580865', '2');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('9', 'chaynyk2', 'chaynyk2chaynyk2', '3.000000000000000000000000000000', '2025-05-23 22:14:50.565455', '2025-05-24 03:14:50.565455', '5', '1', '1', '2025-05-23 22:14:50.565455', '2');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('10', 'chtoto', 'chtotochtotochtotochtoto', '12.000000000000000000000000000000', '2025-05-23 22:15:27.960710', '2025-05-26 16:15:27.960710', '66', '1', '1', '2025-05-23 22:15:27.960710', '2');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `PriceBet`, `UserCreatedId`, `UserBoughtId`, `UserBetId`) VALUES ('11', 'figure', 'figure', '12.000000000000000000000000000000', '2025-05-23 22:16:14.053088', '2025-05-23 01:16:14.053088', '51', '2', '3', '2025-05-23 22:16:14.053087', '22.000000000000000000000000000000', '2', '1', '1');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('12', 'sedobnoe?', 'sedobnoe?', '9.000000000000000000000000000000', '2025-05-23 22:16:46.658828', '2025-05-24 02:16:46.658828', '4', '1', '3', '2025-05-23 22:16:46.658828', '2');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('13', 'strawberry', 'strawberry', '1.000000000000000000000000000000', '2025-05-23 22:17:12.855375', '2025-05-24 10:17:12.855375', '12', '1', '3', '2025-05-23 22:17:12.855375', '2');
INSERT INTO `auction`.`lots` (`Id`, `Name`, `Description`, `PriceStart`, `DateStart`, `DateEnd`, `Hours`, `LotStatus`, `LotType`, `DateCreated`, `UserCreatedId`) VALUES ('14', 'tozeFrukt', 'tozeFrukt', '25.000000000000000000000000000000', '2025-05-23 22:17:53.755552', '2025-05-24 20:17:53.755553', '22', '1', '2', '2025-05-23 22:17:53.755552', '2');
";

            string fileImagesSQL = @"
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('1', 'bb77aa6fe283e5e9843500c89d787aba.jpg', '81d67266-ca18-4e51-a025-a43a4da5384d', '/images/81d67266-ca18-4e51-a025-a43a4da5384d.jpg', '2025-05-23 22:00:55.733572', '0', '1');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('2', '23_eab1cafc01089c601c86251477a88cf6.jpg', '02470c66-d4c3-4d10-ab68-940f9045ffc0', '/images/02470c66-d4c3-4d10-ab68-940f9045ffc0.jpg', '2025-05-23 22:08:32.173048', '0', '2');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('3', '____Annona_cherimola.jpg.webp', 'e752a6b8-88ea-493a-9058-244670a955a7', '/images/e752a6b8-88ea-493a-9058-244670a955a7.webp', '2025-05-23 22:10:48.416984', '0', '3');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('4', '7f35029c762be08b22dcaab1a6fb06ec.jpg', '2baad284-36a2-4c4f-88f8-55ea180f454b', '/images/2baad284-36a2-4c4f-88f8-55ea180f454b.jpg', '2025-05-23 22:11:41.973826', '0', '4');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('5', '9ff04b3ee7b4bddcc94723548cc6ada6.jpg', 'c2d43f17-647d-47cd-8f4b-2fbf3bbaf2e5', '/images/c2d43f17-647d-47cd-8f4b-2fbf3bbaf2e5.jpg', '2025-05-23 22:12:24.415996', '0', '5');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('6', '106-3.jpg', '0e0d5e1f-c618-4977-8b62-40cefe6f1cc9', '/images/0e0d5e1f-c618-4977-8b62-40cefe6f1cc9.jpg', '2025-05-23 22:12:45.887061', '0', '6');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('7', 'a995aa503f698583cd842fad3569350d.jpg', '2fc4252a-095f-4e35-9ef5-3048e5a720ef', '/images/2fc4252a-095f-4e35-9ef5-3048e5a720ef.jpg', '2025-05-23 22:13:12.211757', '0', '7');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('8', 'euJ4mZwHyRY.jpg', '68df6997-8f9b-4db1-9c24-94eef7534b03', '/images/68df6997-8f9b-4db1-9c24-94eef7534b03.jpg', '2025-05-23 22:14:11.581234', '0', '8');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('9', 'images (1).jpg', '886a04b9-be1c-49be-a3b5-9cbbb2593672', '/images/886a04b9-be1c-49be-a3b5-9cbbb2593672.jpg', '2025-05-23 22:14:50.565748', '0', '9');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('10', '1684121552_polinka-top-p-kartinki-starinnie-veshchi-krasivo-2.jpg', '27e2d382-7303-4600-ac2c-ce6c695b58dd', '/images/27e2d382-7303-4600-ac2c-ce6c695b58dd.jpg', '2025-05-23 22:15:27.961070', '0', '10');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('11', '336416186.0.208x208s.jpg', '17ec8d5e-f2c5-47a2-b23f-184aa3964545', '/images/17ec8d5e-f2c5-47a2-b23f-184aa3964545.jpg', '2025-05-23 22:16:14.053412', '0', '11');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('12', 'dragon2640.jpg', '65299560-bc4f-4cb2-b221-f5eded3fe803', '/images/65299560-bc4f-4cb2-b221-f5eded3fe803.jpg', '2025-05-23 22:16:46.659118', '0', '12');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('13', 'qwe.jpg', '397a551b-aadc-400d-b203-9c24a26107db', '/images/397a551b-aadc-400d-b203-9c24a26107db.jpg', '2025-05-23 22:17:12.855726', '0', '13');
INSERT INTO `auction`.`fileimages` (`Id`, `Name`, `Guid`, `Path`, `Created`, `Type`, `LotId`) VALUES ('14', 'rambutan_5006_big-24875.jpg', '82b7fdfd-3c0e-4af9-b1cb-190c617556b8', '/images/82b7fdfd-3c0e-4af9-b1cb-190c617556b8.jpg', '2025-05-23 22:17:53.755854', '0', '14');
";

            stringBuilder.AppendLine(usersSQL);

            stringBuilder.AppendLine(lotsSQL);

            stringBuilder.AppendLine(fileImagesSQL);



            migrationBuilder.Sql(stringBuilder.ToString());
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
