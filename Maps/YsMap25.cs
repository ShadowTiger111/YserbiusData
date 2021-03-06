#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap25 : AMapScripted {
        protected override int MapIndex => 25;
        
        public YserMap25() {
            MapEvent01 = FnCHESLITE_01;
            MapEvent02 = FnCHESDARK_02;
            MapEvent03 = FnVOID_03;
            MapEvent04 = FnPOKERBRG_04;
            MapEvent05 = FnPOKERSW_05;
            MapEvent06 = FnHEARTSDR_06;
            MapEvent07 = FnMOONSW_07;
            MapEvent08 = FnBLAKJAK_08;
            MapEvent09 = FnBLAKJAKK_09;
            MapEvent0A = FnCRIB_0A;
            MapEvent0B = FnCRIBJACK_0B;
            MapEvent0C = FnCRIBFIVE_0C;
            MapEvent0D = FnBRDGFALL_0D;
            MapEvent0E = FnDICEPASS_0E;
            MapEvent0F = FnDICESNAK_0F;
            MapEvent10 = FnDICEBOXC_10;
            MapEvent11 = FnDICEENCA_11;
            MapEvent12 = FnDICEENCB_12;
            MapEvent13 = FnBLJKFOUN_13;
            MapEvent14 = FnCRIBFOUN_14;
            MapEvent15 = FnDICETRSA_15;
            MapEvent16 = FnDICETRSB_16;
            MapEvent17 = FnDICETRSC_17;
            MapEvent18 = FnDICETRSD_18;
            MapEvent19 = FnDICETRSE_19;
            MapEvent1A = FnDICETRSF_1A;
            MapEvent1B = FnDICETRSG_1B;
            MapEvent1C = FnDICETRSH_1C;
            MapEvent1D = FnDICETRSI_1D;
            MapEvent22 = FnBARD_22;
            MapEvent23 = FnAPPLES_23;
            MapEvent24 = FnAPPLEENC_24;
            MapEvent25 = FnCHESENCA_25;
            MapEvent26 = FnCHESENCB_26;
            MapEvent27 = FnCHESENCC_27;
            MapEvent28 = FnCHESENCD_28;
            MapEvent29 = FnCHESENCE_29;
            MapEvent2A = FnCHESENCF_2A;
            MapEvent2B = FnPOKRENCA_2B;
            MapEvent2C = FnCRIBENCA_2C;
            MapEvent2D = FnBLJKENCA_2D;
            MapEvent2E = FnBLJKENCB_2E;
            MapEvent2F = FnCRIBENCB_2F;
            MapEvent30 = FnVARYENCA_30;
            MapEvent31 = FnVARYENCB_31;
            MapEvent34 = FnVARYENCE_34;
            MapEvent35 = FnGATEA_35;
            MapEvent36 = FnTOLABY_36;
            MapEvent37 = FnTXTCHESL_37;
            MapEvent38 = FnTXTCHESD_38;
            MapEvent39 = FnTXTDICEB_39;
            MapEvent3A = FnTXTDICEA_3A;
        }
        
        // === Strings ================================================
        private const string String03FC = "You may leave the chessboard through this opening.";
        private const string String042F = "A knight move here would place you off the chessboard!";
        private const string String0466 = "With a chess piece you may step across the chessboard.";
        private const string String049D = "You may leave the chessboard through this opening.";
        private const string String04D0 = "A knight move here would place you off the chessboard!";
        private const string String0507 = "With a chess piece you may step across the chessboard.";
        private const string String053E = "You fall to your death in the lava below!";
        private const string String0568 = "Planks of the Poker Bridge are made from used playing cards.";
        private const string String05A5 = "The rickety bridge barely holds your weight.";
        private const string String05D2 = "The bridge collapses as you step on it, sending you to your death.";
        private const string String0615 = "The King laughs at his clever ruse.";
        private const string String0639 = "The royal flush beats the Joker!  A bridge forms across the pit.";
        private const string String067A = "A bottomless pit lies before you, and a broken bridge spans the pit.";
        private const string String06BF = "Upon each board are the symbols for 10, Jack, Queen and Ace.  A voice proclaims, 'I call your bluff'.";
        private const string String0725 = "The door bellows, 'I am all hearts!'";
        private const string String074A = "The door proclaims,  'You shot the Moon!'";
        private const string String0774 = "A small button, shaped like the crescent moon, lies just out of reach.";
        private const string String07BB = "The Ace is played as eleven points, scoring the BlackJack!";
        private const string String07F6 = "A door unlocks...";
        private const string String0808 = "You enter a treasure room without any treasure.";
        private const string String0838 = "A dwarf thief voice menacingly orders, 'The Kings guard their treasure.  Only one can find it.'";
        private const string String0898 = "Stand back!  A King guards this wall!";
        private const string String08BE = "The Jack scores the hand 22.  Cribbage is the game.";
        private const string String08F2 = "A door unlocks...";
        private const string String0904 = "The 22nd room of this fine castle...";
        private const string String0929 = "On the floor is a five, on two walls are fives, and the third wall holds a Jack.";
        private const string String097A = "A voice laughs, 'You stand on face up!'";
        private const string String09A2 = "I, the Jack, throw dust in your general direction.";
        private const string String09D5 = "The 5 card smiles back.";
        private const string String09ED = "The Poker Bridge behind you collapses.";
        private const string String0A14 = "Lucky Sevens! Lucky Sevens on the first roll!";
        private const string String0A42 = "The door says, 'Snake eyes' ...";
        private const string String0A62 = "The door shows two squares of six.  'Box Cars' ...";
        private const string String0A95 = "The Blackjack Fountain is made of playing cards.";
        private const string String0AC6 = "Still water fills the basin.";
        private const string String0AE3 = "A sip of it makes you feel healthier and more agile.";
        private const string String0B18 = "As you sip, a voice whispers -";
        private const string String0B37 = "'The Jack has come home.  Thank you for your help.'";
        private const string String0B6B = "The fountain is dry as a bone.";
        private const string String0B8A = "The Cribbage Fountain is bedecked with golden pegs.";
        private const string String0BBE = "A puff of steam from the fountain blows in your face.";
        private const string String0BF4 = "Your Mana is restored and you feel readier to fight.";
        private const string String0C29 = "A voice whispers -";
        private const string String0C3C = "'The Ace has returned.  Three points for you.'";
        private const string String0C6B = "The basin is empty.";
        private const string String0C7F = "A message is inscribed on a wall -- ";
        private const string String0CA4 = "'The Waters of Winter are needed to transform Spring into Summer.";
        private const string String0CE6 = "In return for your deeds, you will receive the Radiance of Summer.'";
        private const string String0D2A = "A note is inscribed on a wall -- ";
        private const string String0D4C = "'To reach En-Li-Kil, you must defeat his Wind Elemental.";
        private const string String0D85 = "Remember to use weapons that do not break when the Wind Elemental attacks.";
        private const string String0DD0 = "A message is written in blood on a wall -- ";
        private const string String0DFC = "'Be careful in the River of Eternity.";
        private const string String0E22 = "The river takes one fourth of your full health every step you take with no opportunity to heal.";
        private const string String0E82 = "'A safe fourth square must be found to cross the Rivers of Eternity.'";
        private const string String0EC8 = "A message is written on a wall -- ";
        private const string String0EEB = "'Use the outer walls to set the location of another's next step in the Parapet Chasm.";
        private const string String0F41 = "Once across, encounter Andreas to gain access to Arnakkian.'";
        private const string String0F7E = "A message is written on a wall -- ";
        private const string String0FA1 = "'The Promise of Spring Renewal must be sworn to convert Autumn to Winter.";
        private const string String0FEB = "In return you will receive the cold Waters of Winter.'";
        private const string String1022 = "An Elf Ranger appears.";
        private const string String1039 = "'In levels below the labyrinth, Snow Elves hide from the curses ";
        private const string String107A = "of Arnakkian and await the day they may return to their faraway land.";
        private const string String10C0 = "A proud tree may be found in their caves.";
        private const string String10EA = "The Snow Elves call this grand tree the Aldbora.";
        private const string String111B = "The Aldbora bears the fruit of knowledge to all adventurers during the season of winter.";
        private const string String1174 = "It lies dormant now, unable to ripen its fruit without the change of seasons and the Radiance of Summer.'";
        private const string String11DE = "A message is scrawled on a wall -- ";
        private const string String1202 = "'Use the Autumn Seeds to transform Winter into flowering Spring.";
        private const string String1243 = "The promise of Spring Renewal for another year will be given in return.'";
        private const string String128C = "A message is carved in the floor -- ";
        private const string String12B1 = "'The bones of a past king may be found in the Elven Caves.'";
        private const string String12ED = "A message is scribbled on a wall -- ";
        private const string String1312 = "'The trumpet sound of the Harvest Horn will announce Summer's conversion to Autumn.";
        private const string String1366 = "From the conversion you will receive the seeds of Autumn.'";
        private const string String13A1 = "A ghost elf bard sings a tale of how four colored magical gems placed side by side can form a rainbow to a far away island.";
        private const string String141D = "The spirit of a beautiful wench appears. She hold a wooden bucket filled wtih floating apples.";
        private const string String147C = "'Step forward and honor me with your kindness!  Bob for apples and win a prize.'";
        private const string String14CD = "You have accepted the ghost's challenge.";
        private const string String14F6 = "You close your eyes and dunk your head into the wood bucket.";
        private const string String1533 = "The ripe apples are rotten and filled with Leeches!";
        private const string String1567 = "You are able to dodge several bursts of flame as you enter a Dragon's Lair.";
        private const string String15B3 = "The gate takes you back to the labyrinth.";
        private const string String15DD = "Use the red squares and you shall turn clockwise on your mount.";
        private const string String161D = "The stallion must go counterclockwise on blue squares!";
        private const string String1654 = "To the west you will find a second dice maze.";
        private const string String1682 = "A maze made out of dice lies just to the north.";
        
        // === Functions ================================================
        private void FnCHESLITE_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetCurrentTile(party), 0x0062);
            L000E: if (JumpNotEqual) goto L001B;
            L0010: RefreshCompareFlags(GetFacing(party));
            L0019: if (JumpEqual) goto L0062;
            L001B: Compare(GetCurrentTile(party), 0x0069);
            L0025: if (JumpNotEqual) goto L0033;
            L0027: Compare(GetFacing(party), 0x0002);
            L0031: if (JumpEqual) goto L0062;
            L0033: Compare(GetCurrentTile(party), 0x0092);
            L003D: if (JumpNotEqual) goto L004A;
            L003F: RefreshCompareFlags(GetFacing(party));
            L0048: if (JumpEqual) goto L0062;
            L004A: Compare(GetCurrentTile(party), 0x0099);
            L0054: if (JumpNotEqual) goto L0072;
            L0056: Compare(GetFacing(party), 0x0002);
            L0060: if (JumpNotEqual) goto L0072;
            L0062: ShowMessage(party, String03FC); // You may leave the chessboard through this opening.
            L006F: goto L0193;
            L0072: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L008F: ax = HasItem(party, 0xEE);
            L009D: if (JumpNotEqual) goto L00A2;
            L009F: goto L0186;
            L00A2: Compare(GetFacing(party), 0x0003);
            L00AC: if (JumpNotEqual) goto L00BA;
            L00AE: si = GetCurrentTile(party) + 0xFFE1;
            L00BA: Compare(GetFacing(party), 0x0002);
            L00C4: if (JumpNotEqual) goto L00D2;
            L00C6: si = GetCurrentTile(party) + 0x0012;
            L00D2: Compare(GetFacing(party), 0x0001);
            L00DC: if (JumpNotEqual) goto L00EA;
            L00DE: si = GetCurrentTile(party) + 0x001F;
            L00EA: RefreshCompareFlags(GetFacing(party));
            L00F3: if (JumpNotEqual) goto L0101;
            L00F5: si = GetCurrentTile(party) + 0xFFEE;
            L0101: Compare(si, 0x42);
            L0104: if (JumpLess) goto L010B;
            L0106: Compare(si, 0x49);
            L0109: if (JumpLessOrEqual) goto L0159;
            L010B: Compare(si, 0x52);
            L010E: if (JumpLess) goto L0115;
            L0110: Compare(si, 0x59);
            L0113: if (JumpLessOrEqual) goto L0159;
            L0115: Compare(si, 0x62);
            L0118: if (JumpLess) goto L011F;
            L011A: Compare(si, 0x69);
            L011D: if (JumpLessOrEqual) goto L0159;
            L011F: Compare(si, 0x72);
            L0122: if (JumpLess) goto L0129;
            L0124: Compare(si, 0x79);
            L0127: if (JumpLessOrEqual) goto L0159;
            L0129: Compare(si, 0x0082);
            L012D: if (JumpLess) goto L0135;
            L012F: Compare(si, 0x0089);
            L0133: if (JumpLessOrEqual) goto L0159;
            L0135: Compare(si, 0x0092);
            L0139: if (JumpLess) goto L0141;
            L013B: Compare(si, 0x0099);
            L013F: if (JumpLessOrEqual) goto L0159;
            L0141: Compare(si, 0x00A2);
            L0145: if (JumpLess) goto L014D;
            L0147: Compare(si, 0x00A9);
            L014B: if (JumpLessOrEqual) goto L0159;
            L014D: Compare(si, 0x00B2);
            L0151: if (JumpLess) goto L0177;
            L0153: Compare(si, 0x00B9);
            L0157: if (JumpGreater) goto L0177;
            L0159: TeleportParty(party, 0x35, 0x02, si, GetFacing(party), isForwardMove);
            L0175: goto L0184;
            L0177: ShowMessage(party, String042F); // A knight move here would place you off the chessboard!
            L0184: goto L0193;
            L0186: ShowMessage(party, String0466); // With a chess piece you may step across the chessboard.
            L0193: return; // RETURN (restoring si);
        }

        private void FnCHESDARK_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetCurrentTile(party), 0x0062);
            L000E: if (JumpNotEqual) goto L001B;
            L0010: RefreshCompareFlags(GetFacing(party));
            L0019: if (JumpEqual) goto L0062;
            L001B: Compare(GetCurrentTile(party), 0x0069);
            L0025: if (JumpNotEqual) goto L0033;
            L0027: Compare(GetFacing(party), 0x0002);
            L0031: if (JumpEqual) goto L0062;
            L0033: Compare(GetCurrentTile(party), 0x0092);
            L003D: if (JumpNotEqual) goto L004A;
            L003F: RefreshCompareFlags(GetFacing(party));
            L0048: if (JumpEqual) goto L0062;
            L004A: Compare(GetCurrentTile(party), 0x0099);
            L0054: if (JumpNotEqual) goto L0072;
            L0056: Compare(GetFacing(party), 0x0002);
            L0060: if (JumpNotEqual) goto L0072;
            L0062: ShowMessage(party, String049D); // You may leave the chessboard through this opening.
            L006F: goto L0193;
            L0072: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L008F: ax = HasItem(party, 0xEE);
            L009D: if (JumpNotEqual) goto L00A2;
            L009F: goto L0186;
            L00A2: Compare(GetFacing(party), 0x0003);
            L00AC: if (JumpNotEqual) goto L00BA;
            L00AE: si = GetCurrentTile(party) + 0xFFDF;
            L00BA: Compare(GetFacing(party), 0x0002);
            L00C4: if (JumpNotEqual) goto L00D2;
            L00C6: si = GetCurrentTile(party) + 0xFFF2;
            L00D2: Compare(GetFacing(party), 0x0001);
            L00DC: if (JumpNotEqual) goto L00EA;
            L00DE: si = GetCurrentTile(party) + 0x0021;
            L00EA: RefreshCompareFlags(GetFacing(party));
            L00F3: if (JumpNotEqual) goto L0101;
            L00F5: si = GetCurrentTile(party) + 0x000E;
            L0101: Compare(si, 0x42);
            L0104: if (JumpLess) goto L010B;
            L0106: Compare(si, 0x49);
            L0109: if (JumpLessOrEqual) goto L0159;
            L010B: Compare(si, 0x52);
            L010E: if (JumpLess) goto L0115;
            L0110: Compare(si, 0x59);
            L0113: if (JumpLessOrEqual) goto L0159;
            L0115: Compare(si, 0x62);
            L0118: if (JumpLess) goto L011F;
            L011A: Compare(si, 0x69);
            L011D: if (JumpLessOrEqual) goto L0159;
            L011F: Compare(si, 0x72);
            L0122: if (JumpLess) goto L0129;
            L0124: Compare(si, 0x79);
            L0127: if (JumpLessOrEqual) goto L0159;
            L0129: Compare(si, 0x0082);
            L012D: if (JumpLess) goto L0135;
            L012F: Compare(si, 0x0089);
            L0133: if (JumpLessOrEqual) goto L0159;
            L0135: Compare(si, 0x0092);
            L0139: if (JumpLess) goto L0141;
            L013B: Compare(si, 0x0099);
            L013F: if (JumpLessOrEqual) goto L0159;
            L0141: Compare(si, 0x00A2);
            L0145: if (JumpLess) goto L014D;
            L0147: Compare(si, 0x00A9);
            L014B: if (JumpLessOrEqual) goto L0159;
            L014D: Compare(si, 0x00B2);
            L0151: if (JumpLess) goto L0177;
            L0153: Compare(si, 0x00B9);
            L0157: if (JumpGreater) goto L0177;
            L0159: TeleportParty(party, 0x35, 0x02, si, GetFacing(party), isForwardMove);
            L0175: goto L0184;
            L0177: ShowMessage(party, String04D0); // A knight move here would place you off the chessboard!
            L0184: goto L0193;
            L0186: ShowMessage(party, String0507); // With a chess piece you may step across the chessboard.
            L0193: return; // RETURN (restoring si);
        }

        private void FnVOID_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String053E); // You fall to your death in the lava below!
            L0010: DamagePlayer(party, GetMaxHits(party));
            L0021: return; // RETURN;
        }

        private void FnPOKERBRG_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0568); // Planks of the Poker Bridge are made from used playing cards.
            L0010: Compare(GetState(party, 0x01, 0x01), 0x0001);
            L0024: if (JumpNotEqual) goto L0056;
            L0026: ShowMessage(party, String05A5); // The rickety bridge barely holds your weight.
            L0033: SetFloorObject(party, 0x00, 0xDD);
            L0043: SetFloorPassable(party, 0xDD, 0x01);
            L0054: goto L0081;
            L0056: ShowMessage(party, String05D2); // The bridge collapses as you step on it, sending you to your death.
            L0063: ShowMessage(party, String0615); // The King laughs at his clever ruse.
            L0070: DamagePlayer(party, GetMaxHits(party));
            L0081: return; // RETURN;
        }

        private void FnPOKERSW_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xEC, 0xEC);
            L0016: if (JumpEqual) goto L005D;
            L0018: SetState(party, 0x01, 0x01, 0x01);
            L002D: SetFloorObject(party, 0x00, 0xDD);
            L003D: SetFloorPassable(party, 0xDD, 0x01);
            L004E: ShowMessage(party, String0639); // The royal flush beats the Joker!  A bridge forms across the pit.
            L005B: goto L0077;
            L005D: ShowMessage(party, String067A); // A bottomless pit lies before you, and a broken bridge spans the pit.
            L006A: ShowMessage(party, String06BF); // Upon each board are the symbols for 10, Jack, Queen and Ace.  A voice proclaims, 'I call your bluff'.
            L0077: return; // RETURN;
        }

        private void FnHEARTSDR_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0725); // The door bellows, 'I am all hearts!'
            L0010: return; // RETURN;
        }

        private void FnMOONSW_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xEB, 0xEB);
            L0016: if (JumpEqual) goto L0053;
            L0018: SetWallObject(party, 0x01, 0xBF, 0x03);
            L002E: SetWallPassable(party, 0xBF, 0x03, 0x01);
            L0044: ShowMessage(party, String074A); // The door proclaims,  'You shot the Moon!'
            L0051: goto L0060;
            L0053: ShowMessage(party, String0774); // A small button, shaped like the crescent moon, lies just out of reach.
            L0060: return; // RETURN;
        }

        private void FnBLAKJAK_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xED, 0xED);
            L0016: if (JumpEqual) goto L0060;
            L0018: SetWallObject(party, 0x01, 0x8D, 0x01);
            L002E: SetWallPassable(party, 0x8D, 0x01, 0x01);
            L0044: ShowMessage(party, String07BB); // The Ace is played as eleven points, scoring the BlackJack!
            L0051: ShowMessage(party, String07F6); // A door unlocks...
            L005E: goto L007A;
            L0060: ShowMessage(party, String0808); // You enter a treasure room without any treasure.
            L006D: ShowMessage(party, String0838); // A dwarf thief voice menacingly orders, 'The Kings guard their treasure.  Only one can find it.'
            L007A: return; // RETURN;
        }

        private void FnBLAKJAKK_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0898); // Stand back!  A King guards this wall!
            L0010: return; // RETURN;
        }

        private void FnCRIB_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xEA, 0xEA);
            L0016: if (JumpEqual) goto L0060;
            L0018: SetWallObject(party, 0x01, 0x7D, 0x03);
            L002E: SetWallPassable(party, 0x7D, 0x03, 0x01);
            L0044: ShowMessage(party, String08BE); // The Jack scores the hand 22.  Cribbage is the game.
            L0051: ShowMessage(party, String08F2); // A door unlocks...
            L005E: goto L0087;
            L0060: ShowMessage(party, String0904); // The 22nd room of this fine castle...
            L006D: ShowMessage(party, String0929); // On the floor is a five, on two walls are fives, and the third wall holds a Jack.
            L007A: ShowMessage(party, String097A); // A voice laughs, 'You stand on face up!'
            L0087: return; // RETURN;
        }

        private void FnCRIBJACK_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09A2); // I, the Jack, throw dust in your general direction.
            L0010: return; // RETURN;
        }

        private void FnCRIBFIVE_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09D5); // The 5 card smiles back.
            L0010: return; // RETURN;
        }

        private void FnBRDGFALL_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09ED); // The Poker Bridge behind you collapses.
            L0010: SetState(party, 0x01, 0x01, 0x00);
            L0024: SetFloorObject(party, 0x01, 0xDD);
            L0035: return; // RETURN;
        }

        private void FnDICEPASS_0E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A14); // Lucky Sevens! Lucky Sevens on the first roll!
            L0010: return; // RETURN;
        }

        private void FnDICESNAK_0F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A42); // The door says, 'Snake eyes' ...
            L0010: return; // RETURN;
        }

        private void FnDICEBOXC_10(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A62); // The door shows two squares of six.  'Box Cars' ...
            L0010: return; // RETURN;
        }

        private void FnDICEENCA_11(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x0A);
            L0015: AddEncounter(party, 0x02, 0x0A);
            L0027: AddEncounter(party, 0x03, 0x0A);
            L0039: AddEncounter(party, 0x04, 0x0A);
            L004B: AddEncounter(party, 0x05, 0x04);
            L005D: AddEncounter(party, 0x06, 0x04);
            L006F: return; // RETURN;
        }

        private void FnDICEENCB_12(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x0A);
            L0015: AddEncounter(party, 0x02, 0x0A);
            L0027: AddEncounter(party, 0x03, 0x0A);
            L0039: AddEncounter(party, 0x04, 0x0A);
            L004B: AddEncounter(party, 0x05, 0x0A);
            L005D: AddEncounter(party, 0x06, 0x0A);
            L006F: return; // RETURN;
        }

        private void FnBLJKFOUN_13(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A95); // The Blackjack Fountain is made of playing cards.
            L0010: RefreshCompareFlags(GetState(party, 0x02, 0x7E));
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00AF;
            L0028: SetState(party, 0x02, 0x7E, 0x01);
            L003D: RemoveItem(party, 0xEA);
            L0049: ShowPortrait(party, 0x0042);
            L0056: ModifyAttribute(party, 0x02, 0x0003);
            L0068: HealPlayer(party, GetMaxHits(party));
            L0079: ShowMessage(party, String0AC6); // Still water fills the basin.
            L0086: ShowMessage(party, String0AE3); // A sip of it makes you feel healthier and more agile.
            L0093: ShowMessage(party, String0B18); // As you sip, a voice whispers -
            L00A0: ShowMessage(party, String0B37); // 'The Jack has come home.  Thank you for your help.'
            L00AD: goto L00BC;
            L00AF: ShowMessage(party, String0B6B); // The fountain is dry as a bone.
            L00BC: return; // RETURN;
        }

        private void FnCRIBFOUN_14(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B8A); // The Cribbage Fountain is bedecked with golden pegs.
            L0010: RefreshCompareFlags(GetState(party, 0x02, 0x7F));
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00AB;
            L0028: SetState(party, 0x02, 0x7F, 0x01);
            L003D: ShowPortrait(party, 0x0042);
            L004A: RemoveItem(party, 0xED);
            L0056: ModifyAttribute(party, 0x03, 0x0003);
            L0068: AddMana(party, 0x0BB8);
            L0075: ShowMessage(party, String0BBE); // A puff of steam from the fountain blows in your face.
            L0082: ShowMessage(party, String0BF4); // Your Mana is restored and you feel readier to fight.
            L008F: ShowMessage(party, String0C29); // A voice whispers -
            L009C: ShowMessage(party, String0C3C); // 'The Ace has returned.  Three points for you.'
            L00A9: goto L00B8;
            L00AB: ShowMessage(party, String0C6B); // The basin is empty.
            L00B8: return; // RETURN;
        }

        private void FnDICETRSA_15(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C7F); // A message is inscribed on a wall -- 
            L0010: ShowRunes(party, String0CA4); // 'The Waters of Winter are needed to transform Spring into Summer.
            L001D: ShowRunes(party, String0CE6); // In return for your deeds, you will receive the Radiance of Summer.'
            L002A: return; // RETURN;
        }

        private void FnDICETRSB_16(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D2A); // A note is inscribed on a wall -- 
            L0010: ShowRunes(party, String0D4C); // 'To reach En-Li-Kil, you must defeat his Wind Elemental.
            L001D: ShowRunes(party, String0D85); // Remember to use weapons that do not break when the Wind Elemental attacks.
            L002A: return; // RETURN;
        }

        private void FnDICETRSC_17(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0DD0); // A message is written in blood on a wall -- 
            L0010: ShowRunes(party, String0DFC); // 'Be careful in the River of Eternity.
            L001D: ShowRunes(party, String0E22); // The river takes one fourth of your full health every step you take with no opportunity to heal.
            L002A: ShowRunes(party, String0E82); // 'A safe fourth square must be found to cross the Rivers of Eternity.'
            L0037: return; // RETURN;
        }

        private void FnDICETRSD_18(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0EC8); // A message is written on a wall -- 
            L0010: ShowRunes(party, String0EEB); // 'Use the outer walls to set the location of another's next step in the Parapet Chasm.
            L001D: ShowRunes(party, String0F41); // Once across, encounter Andreas to gain access to Arnakkian.'
            L002A: return; // RETURN;
        }

        private void FnDICETRSE_19(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0F7E); // A message is written on a wall -- 
            L0010: ShowRunes(party, String0FA1); // 'The Promise of Spring Renewal must be sworn to convert Autumn to Winter.
            L001D: ShowRunes(party, String0FEB); // In return you will receive the cold Waters of Winter.'
            L002A: return; // RETURN;
        }

        private void FnDICETRSF_1A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x001F);
            L0010: ShowMessage(party, String1022); // An Elf Ranger appears.
            L001D: ShowMessage(party, String1039); // 'In levels below the labyrinth, Snow Elves hide from the curses 
            L002A: ShowMessage(party, String107A); // of Arnakkian and await the day they may return to their faraway land.
            L0037: ShowMessage(party, String10C0); // A proud tree may be found in their caves.
            L0044: ShowMessage(party, String10EA); // The Snow Elves call this grand tree the Aldbora.
            L0051: ShowMessage(party, String111B); // The Aldbora bears the fruit of knowledge to all adventurers during the season of winter.
            L005E: ShowMessage(party, String1174); // It lies dormant now, unable to ripen its fruit without the change of seasons and the Radiance of Summer.'
            L006B: return; // RETURN;
        }

        private void FnDICETRSG_1B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String11DE); // A message is scrawled on a wall -- 
            L0010: ShowRunes(party, String1202); // 'Use the Autumn Seeds to transform Winter into flowering Spring.
            L001D: ShowRunes(party, String1243); // The promise of Spring Renewal for another year will be given in return.'
            L002A: return; // RETURN;
        }

        private void FnDICETRSH_1C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String128C); // A message is carved in the floor -- 
            L0010: ShowRunes(party, String12B1); // 'The bones of a past king may be found in the Elven Caves.'
            L001D: return; // RETURN;
        }

        private void FnDICETRSI_1D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String12ED); // A message is scribbled on a wall -- 
            L0010: ShowRunes(party, String1312); // 'The trumpet sound of the Harvest Horn will announce Summer's conversion to Autumn.
            L001D: ShowRunes(party, String1366); // From the conversion you will receive the seeds of Autumn.'
            L002A: return; // RETURN;
        }

        private void FnBARD_22(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String13A1); // A ghost elf bard sings a tale of how four colored magical gems placed side by side can form a rainbow to a far away island.
            L0010: return; // RETURN;
        }

        private void FnAPPLES_23(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String141D); // The spirit of a beautiful wench appears. She hold a wooden bucket filled wtih floating apples.
            L0010: ShowMessage(party, String147C); // 'Step forward and honor me with your kindness!  Bob for apples and win a prize.'
            L001D: return; // RETURN;
        }

        private void FnAPPLEENC_24(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String14CD); // You have accepted the ghost's challenge.
            L0010: ShowMessage(party, String14F6); // You close your eyes and dunk your head into the wood bucket.
            L001D: ShowMessage(party, String1533); // The ripe apples are rotten and filled with Leeches!
            L002A: AddEncounter(party, 0x01, 0x1A);
            L003C: AddEncounter(party, 0x02, 0x1A);
            L004E: AddEncounter(party, 0x03, 0x1B);
            L0060: AddEncounter(party, 0x04, 0x1B);
            L0072: AddEncounter(party, 0x05, 0x1A);
            L0084: AddEncounter(party, 0x06, 0x1A);
            L0096: return; // RETURN;
        }

        private void FnCHESENCA_25(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1C);
            L0015: AddEncounter(party, 0x02, 0x1D);
            L0027: AddEncounter(party, 0x03, 0x1E);
            L0039: AddEncounter(party, 0x04, 0x1F);
            L004B: AddEncounter(party, 0x05, 0x20);
            L005D: AddEncounter(party, 0x06, 0x21);
            L006F: return; // RETURN;
        }

        private void FnCHESENCB_26(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1E);
            L0015: AddEncounter(party, 0x02, 0x1E);
            L0027: AddEncounter(party, 0x03, 0x1E);
            L0039: AddEncounter(party, 0x04, 0x1E);
            L004B: AddEncounter(party, 0x05, 0x1E);
            L005D: AddEncounter(party, 0x06, 0x1E);
            L006F: return; // RETURN;
        }

        private void FnCHESENCC_27(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x1F);
            L0027: AddEncounter(party, 0x03, 0x1F);
            L0039: AddEncounter(party, 0x04, 0x1F);
            L004B: AddEncounter(party, 0x05, 0x1F);
            L005D: AddEncounter(party, 0x06, 0x1F);
            L006F: return; // RETURN;
        }

        private void FnCHESENCD_28(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x20);
            L0015: AddEncounter(party, 0x02, 0x20);
            L0027: AddEncounter(party, 0x03, 0x20);
            L0039: AddEncounter(party, 0x04, 0x20);
            L004B: AddEncounter(party, 0x05, 0x26);
            L005D: AddEncounter(party, 0x06, 0x26);
            L006F: return; // RETURN;
        }

        private void FnCHESENCE_29(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x22);
            L0015: AddEncounter(party, 0x02, 0x22);
            L0027: AddEncounter(party, 0x03, 0x22);
            L0039: AddEncounter(party, 0x04, 0x22);
            L004B: AddEncounter(party, 0x05, 0x22);
            L005D: AddEncounter(party, 0x06, 0x1D);
            L006F: ax = HasItem(party, 0xEB);
            L007D: if (JumpEqual) goto L00A0;
            L007F: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x90, 0xAF);
            L009E: goto L00C0;
            L00A0: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xEB, 0xD0);
            L00C0: return; // RETURN;
        }

        private void FnCHESENCF_2A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x18);
            L0015: AddEncounter(party, 0x02, 0x18);
            L0027: AddEncounter(party, 0x03, 0x15);
            L0039: AddEncounter(party, 0x04, 0x18);
            L004B: AddEncounter(party, 0x05, 0x15);
            L005D: AddEncounter(party, 0x06, 0x1C);
            L006F: ax = HasItem(party, 0xEC);
            L007D: if (JumpEqual) goto L00A0;
            L007F: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x8D, 0xCF);
            L009E: goto L00C0;
            L00A0: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xEC, 0xD0);
            L00C0: return; // RETURN;
        }

        private void FnPOKRENCA_2B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x1F);
            L0027: AddEncounter(party, 0x03, 0x1F);
            L0039: AddEncounter(party, 0x04, 0x1F);
            L004B: AddEncounter(party, 0x05, 0x1F);
            L005D: AddEncounter(party, 0x06, 0x1F);
            L006F: return; // RETURN;
        }

        private void FnCRIBENCA_2C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x23);
            L0015: AddEncounter(party, 0x02, 0x23);
            L0027: AddEncounter(party, 0x05, 0x23);
            L0039: AddEncounter(party, 0x06, 0x23);
            L004B: AddTreasure(party, 0x2710, 0x00, 0x00, 0xD0, 0xD0, 0x71);
            L006C: return; // RETURN;
        }

        private void FnBLJKENCA_2D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x26);
            L0015: AddEncounter(party, 0x02, 0x26);
            L0027: AddEncounter(party, 0x03, 0x26);
            L0039: AddEncounter(party, 0x04, 0x26);
            L004B: AddEncounter(party, 0x05, 0x26);
            L005D: AddEncounter(party, 0x06, 0x26);
            L006F: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0xD0, 0x1D);
            L008F: return; // RETURN;
        }

        private void FnBLJKENCB_2E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x26);
            L0015: AddEncounter(party, 0x02, 0x26);
            L0027: AddEncounter(party, 0x03, 0x26);
            L0039: AddEncounter(party, 0x04, 0x26);
            L004B: AddEncounter(party, 0x05, 0x26);
            L005D: AddEncounter(party, 0x06, 0x26);
            L006F: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0xD0, 0xBE);
            L008F: return; // RETURN;
        }

        private void FnCRIBENCB_2F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1567); // You are able to dodge several bursts of flame as you enter a Dragon's Lair.
            L0010: AddEncounter(party, 0x01, 0x24);
            L0022: AddEncounter(party, 0x02, 0x24);
            L0034: AddEncounter(party, 0x03, 0x24);
            L0046: AddEncounter(party, 0x05, 0x25);
            L0058: AddEncounter(party, 0x06, 0x25);
            L006A: AddTreasure(party, 0x2710, 0x00, 0x00, 0xCF, 0xBD, 0x5C);
            L008B: return; // RETURN;
        }

        private void FnVARYENCA_30(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x04);
            L0015: AddEncounter(party, 0x02, 0x04);
            L0027: AddEncounter(party, 0x04, 0x04);
            L0039: AddEncounter(party, 0x05, 0x04);
            L004B: return; // RETURN;
        }

        private void FnVARYENCB_31(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x0E);
            L0015: AddEncounter(party, 0x02, 0x0E);
            L0027: AddEncounter(party, 0x03, 0x0E);
            L0039: AddEncounter(party, 0x05, 0x0D);
            L004B: return; // RETURN;
        }

        private void FnVARYENCE_34(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x13);
            L0015: AddEncounter(party, 0x02, 0x13);
            L0027: AddEncounter(party, 0x03, 0x13);
            L0039: AddEncounter(party, 0x04, 0x13);
            L004B: AddEncounter(party, 0x05, 0x17);
            L005D: AddEncounter(party, 0x06, 0x02);
            L006F: return; // RETURN;
        }

        private void FnGATEA_35(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x35, 0x01, 0x3F, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTOLABY_36(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String15B3); // The gate takes you back to the labyrinth.
            L0010: return; // RETURN;
        }

        private void FnTXTCHESL_37(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String15DD); // Use the red squares and you shall turn clockwise on your mount.
            L0010: return; // RETURN;
        }

        private void FnTXTCHESD_38(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String161D); // The stallion must go counterclockwise on blue squares!
            L0010: return; // RETURN;
        }

        private void FnTXTDICEB_39(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1654); // To the west you will find a second dice maze.
            L0010: return; // RETURN;
        }

        private void FnTXTDICEA_3A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1682); // A maze made out of dice lies just to the north.
            L0010: return; // RETURN;
        }

    }
}
