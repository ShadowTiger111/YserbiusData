namespace ZCF.Scripts.Maps {
    class YserMap00 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "The gateway leads to THE MINES.";
        private const string String041C = "The gateway leads to THE HALL OF DOORS.";
        private const string String0444 = "The gateway leads to THE SOLDIERS  QUARTERS.";
        private const string String0471 = "The gateway is the DUNGEON EXIT.";
        private const string String0492 = "Hail, conquering HERO OF YSERBIUS!";
        private const string String04B5 = "All of Twinion bows to your prominence!!";
        private const string String04DE = "There is a teleport in the west wall.";
        private const string String0504 = "This room contains the gateway to the Labyrinth.";
        private const string String0535 = "The Thieves' Key unlocks this door!";
        private const string String0559 = "This room contains the gateway to the Labyrinth.";
        private const string String058A = "The Thieves' Key is needed to unlock this door.";
        private const string String05BA = "The Thieves' Key is needed to unlock this door.";
        private const string String05EA = "Only heroes of the twentieth level or higher may venture beyond this door.";
        private const string String0635 = "Good Journeys, brave hero.";
        private const string String0650 = "Only heroes of the twentieth level or higher may venture beyond this door.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => TOMINES_01;
        private void TOMINES_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0xFD, 0x02, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => TOTREAS_02;
        private void TOTREAS_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x10, 0x04, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent03 => TOSOLDQU_03;
        private void TOSOLDQU_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x0F, 0x06, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent04 => EXITDUNG_04;
        private void EXITDUNG_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ExitDungeon(party);
            L000B: // RETURN;
        }

        private override MapEventHandler MapEvent05 => DOORMESA_05;
        private void DOORMESA_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // The gateway leads to THE MINES.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent06 => DOORMESB_06;
        private void DOORMESB_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String041C); // The gateway leads to THE HALL OF DOORS.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent07 => DOORMESC_07;
        private void DOORMESC_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0444); // The gateway leads to THE SOLDIERS  QUARTERS.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent08 => DOORMESD_08;
        private void DOORMESD_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0471); // The gateway is the DUNGEON EXIT.
            L0010: ax = CheckState08(party, 0x02, 0x6A);
            L0023: if (result.equal) goto L003F;
            L0025: ShowMessage(party, String0492); // Hail, conquering HERO OF YSERBIUS!
            L0032: ShowMessage(party, String04B5); // All of Twinion bows to your prominence!!
            L003F: // RETURN;
        }

        private override MapEventHandler MapEvent09 => TELEPORT_09;
        private void TELEPORT_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x00, 0x5D, 0x01, 0x33);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent0A => TELEMESS_0A;
        private void TELEMESS_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04DE); // There is a teleport in the west wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0B => DOORMESS_0B;
        private void DOORMESS_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel44(party, 0x0014);
            L0011: if (result.notequal) goto L0016;
            L0013: goto L011F;
            L0016: ax = CheckState04(party, 0x02, 0x78);
            L0027: compare(ax, 0x0001);
            L002A: if (result.notequal) goto L005A;
            L002C: ShowMessage(party, String0504); // This room contains the gateway to the Labyrinth.
            L0039: Push(01);
            L003D: ax = GetFacing24(party);
            L0044: PushStack(ax);
            L0045: ax = GetNextTile20(party);
            L004C: PushStack(ax);
            L004D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0057: goto L011D;
            L005A: ax = HasItem50(party, 0xFB);
            L0068: if (result.notequal) goto L006D;
            L006A: goto L0110;
            L006D: ShowMessage(party, String0535); // The Thieves' Key unlocks this door!
            L007A: ShowMessage(party, String0559); // This room contains the gateway to the Labyrinth.
            L0087: SetState00(party, 0x02, 0x78, 0x01);
            L009C: RemoveItem4C(party, 0xFB);
            L00A8: RemoveItem4C(party, 0xD2);
            L00B4: RemoveItem4C(party, 0xD3);
            L00C0: RemoveItem4C(party, 0xD9);
            L00CC: RemoveItem4C(party, 0xE1);
            L00D8: RemoveItem4C(party, 0xE2);
            L00E4: RemoveItem4C(party, 0xF8);
            L00F0: Push(01);
            L00F4: ax = GetFacing24(party);
            L00FB: PushStack(ax);
            L00FC: ax = GetNextTile20(party);
            L0103: PushStack(ax);
            L0104: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L010E: goto L011D;
            L0110: ShowMessage(party, String058A); // The Thieves' Key is needed to unlock this door.
            L011D: goto L0156;
            L011F: ShowMessage(party, String05BA); // The Thieves' Key is needed to unlock this door.
            L012C: ShowMessage(party, String05EA); // Only heroes of the twentieth level or higher may venture beyond this door.
            L0139: PushStack(0x00);
            L013C: ax = GetFacing24(party);
            L0143: PushStack(ax);
            L0144: ax = GetNextTile20(party);
            L014B: PushStack(ax);
            L014C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0156: // RETURN;
        }

        private override MapEventHandler MapEvent0C => PRTYPORT_0C;
        private void PRTYPORT_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel44(party, 0x0014);
            L0011: if (result.equal) goto L0022;
            L0013: ShowMessage(party, String0635); // Good Journeys, brave hero.
            L0020: goto L0049;
            L0022: ShowMessage(party, String0650); // Only heroes of the twentieth level or higher may venture beyond this door.
            L002F: SetMoveMap(party, 0x00, 0x02, 0x01, 0x01);
            L0049: // RETURN;
        }

        private override MapEventHandler MapEvent0D => NOJOIN_0D;
        private void NOJOIN_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TileIsNoJoinArea(party);
            L000B: // RETURN;
        }

    }
}
