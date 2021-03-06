#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap08 : AMapScripted {
        protected override int MapIndex => 8;
        
        public YserMap08() {
            MapEvent01 = FnSTRSTELE_01;
            MapEvent02 = FnKEYDOOR_02;
            MapEvent03 = FnGOLDAENC_03;
            MapEvent04 = FnGOLDBENC_04;
            MapEvent05 = FnCROWN_05;
            MapEvent06 = FnITEMBENC_06;
            MapEvent07 = FnITEMCENC_07;
            MapEvent08 = FnSTRMNSTR_08;
            MapEvent09 = FnTUFMNSTR_09;
            MapEvent0A = FnSTRSMESS_0A;
            MapEvent0B = FnNPCCHATA_0B;
            MapEvent0C = FnNPCCHATB_0C;
        }
        
        // === Strings ================================================
        private const string String03FC = "The O Rune Key unlocked the door.";
        private const string String041E = "The door is locked. It requires a special key.";
        private const string String044D = "Skeletons on the floor stir to life.";
        private const string String0472 = "Among the bones on the floor are pieces of gold. The bones begin to move.";
        private const string String04BC = "A clutch of Large-Uns growl at you.";
        private const string String04E0 = "A Large-Un tosses a piece of wood aside as he and his friends attack.";
        private const string String0526 = "You have interrupted a Lizardite religious service.";
        private const string String055A = "As you enter the room, the O Rune Key vanishes.";
        private const string String058A = "You see a Lizardite proudly wearing the Crown of King Cleowyn.";
        private const string String05C9 = "You run into the living skeletons of King Cleowyn's guards.";
        private const string String0605 = "One of the skeletons approaching you holds a piece of paper in its bony hand.";
        private const string String0653 = "Reptilian bodies stir as you draw near.";
        private const string String067B = "The stairs through the west gateway lead down a level.";
        private const string String06B2 = "A Human Wizard teleports into the room you occupy.";
        private const string String06E5 = "Be careful when you find the way to open the door that leads to the nether depths of this dungeon.";
        private const string String0748 = "All quest items from Cleowyn's Palace levels will be stripped from you.";
        private const string String0790 = "But if you are indeed ready to enter the lower depths, you will no longer need Cleowyn's toys.";
        private const string String07EF = "The Human Wizard smiles sheepishly and teleports somewhere else.";
        private const string String0830 = "You encounter a sleepy Troll Knight.";
        private const string String0855 = "The Galabryan kings brought the great wizard Arnakkian Slowfoot to Twinion. The island grew famous and rich thanks to this wizard.";
        private const string String08D8 = "But the wizard had his own schemes, and soon he and good King Leowyn Galabryan were at loggerheads. Supposedly, the wizard had the king assassinated.";
        private const string String096E = "The Troll Knight blinks at you dumbly and falls asleep.";
        
        // === Functions ================================================
        private void FnSTRSTELE_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x03, 0x01, 0xC2, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnKEYDOOR_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xDA, 0xDA);
            L0016: if (JumpEqual) goto L0063;
            L0018: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0036: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0054: ShowMessage(party, String03FC); // The O Rune Key unlocked the door.
            L0061: goto L008D;
            L0063: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0080: ShowMessage(party, String041E); // The door is locked. It requires a special key.
            L008D: return; // RETURN;
        }

        private void FnGOLDAENC_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x18), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String044D); // Skeletons on the floor stir to life.
            L0026: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0066: SetState(party, 0x02, 0x18, 0x01);
            L007B: ShowMessage(party, String0472); // Among the bones on the floor are pieces of gold. The bones begin to move.
            L0088: Compare(PartyCount(party), 0x0001);
            L0093: if (JumpNotEqual) goto L00AA;
            L0095: AddEncounter(party, 0x01, 0x01);
            L00A7: goto L0144;
            L00AA: Compare(PartyCount(party), 0x0002);
            L00B5: if (JumpEqual) goto L00C4;
            L00B7: Compare(PartyCount(party), 0x0003);
            L00C2: if (JumpNotEqual) goto L00FC;
            L00C4: AddEncounter(party, 0x01, 0x02);
            L00D6: AddEncounter(party, 0x02, 0x04);
            L00E8: AddEncounter(party, 0x03, 0x06);
            L00FA: goto L0144;
            L00FC: AddEncounter(party, 0x01, 0x01);
            L010E: AddEncounter(party, 0x02, 0x02);
            L0120: AddEncounter(party, 0x03, 0x03);
            L0132: AddEncounter(party, 0x04, 0x04);
            L0144: return; // RETURN;
        }

        private void FnGOLDBENC_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xC6);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String04BC); // A clutch of Large-Uns growl at you.
            L0020: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x1770, 0x00, 0x00, 0x00, 0x00, 0xC6);
            L0060: ShowMessage(party, String04E0); // A Large-Un tosses a piece of wood aside as he and his friends attack.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpNotEqual) goto L00A1;
            L007A: AddEncounter(party, 0x01, 0x19);
            L008C: AddEncounter(party, 0x02, 0x1A);
            L009E: goto L0198;
            L00A1: Compare(PartyCount(party), 0x0002);
            L00AC: if (JumpNotEqual) goto L00E7;
            L00AE: AddEncounter(party, 0x01, 0x19);
            L00C0: AddEncounter(party, 0x02, 0x1A);
            L00D2: AddEncounter(party, 0x03, 0x19);
            L00E4: goto L0198;
            L00E7: Compare(PartyCount(party), 0x0003);
            L00F2: if (JumpNotEqual) goto L013E;
            L00F4: AddEncounter(party, 0x01, 0x1A);
            L0106: AddEncounter(party, 0x02, 0x1A);
            L0118: AddEncounter(party, 0x03, 0x1B);
            L012A: AddEncounter(party, 0x04, 0x1B);
            L013C: goto L0198;
            L013E: AddEncounter(party, 0x01, 0x1B);
            L0150: AddEncounter(party, 0x02, 0x1B);
            L0162: AddEncounter(party, 0x03, 0x1B);
            L0174: AddEncounter(party, 0x04, 0x1B);
            L0186: AddEncounter(party, 0x05, 0x1C);
            L0198: return; // RETURN;
        }

        private void FnCROWN_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x69);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String0526); // You have interrupted a Lizardite religious service.
            L0020: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L003F: goto L0087;
            L0041: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xCF, 0x69);
            L0061: RemoveItem(party, 0xDA);
            L006D: ShowMessage(party, String055A); // As you enter the room, the O Rune Key vanishes.
            L007A: ShowMessage(party, String058A); // You see a Lizardite proudly wearing the Crown of King Cleowyn.
            L0087: Compare(PartyCount(party), 0x0001);
            L0092: if (JumpNotEqual) goto L00BB;
            L0094: AddEncounter(party, 0x01, 0x21);
            L00A6: AddEncounter(party, 0x02, 0x21);
            L00B8: goto L018B;
            L00BB: Compare(PartyCount(party), 0x0002);
            L00C6: if (JumpEqual) goto L00D5;
            L00C8: Compare(PartyCount(party), 0x0003);
            L00D3: if (JumpNotEqual) goto L011F;
            L00D5: AddEncounter(party, 0x01, 0x21);
            L00E7: AddEncounter(party, 0x02, 0x21);
            L00F9: AddEncounter(party, 0x03, 0x21);
            L010B: AddEncounter(party, 0x05, 0x21);
            L011D: goto L018B;
            L011F: AddEncounter(party, 0x01, 0x21);
            L0131: AddEncounter(party, 0x02, 0x21);
            L0143: AddEncounter(party, 0x03, 0x21);
            L0155: AddEncounter(party, 0x04, 0x21);
            L0167: AddEncounter(party, 0x05, 0x21);
            L0179: AddEncounter(party, 0x06, 0x21);
            L018B: return; // RETURN;
        }

        private void FnITEMBENC_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xBB);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String05C9); // You run into the living skeletons of King Cleowyn's guards.
            L0020: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0x00, 0xBC);
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x1B58, 0x00, 0x00, 0x00, 0x00, 0xBB);
            L0060: ShowMessage(party, String0605); // One of the skeletons approaching you holds a piece of paper in its bony hand.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpNotEqual) goto L008F;
            L007A: AddEncounter(party, 0x01, 0x15);
            L008C: goto L0129;
            L008F: Compare(PartyCount(party), 0x0002);
            L009A: if (JumpEqual) goto L00A9;
            L009C: Compare(PartyCount(party), 0x0003);
            L00A7: if (JumpNotEqual) goto L00E1;
            L00A9: AddEncounter(party, 0x01, 0x15);
            L00BB: AddEncounter(party, 0x02, 0x16);
            L00CD: AddEncounter(party, 0x03, 0x17);
            L00DF: goto L0129;
            L00E1: AddEncounter(party, 0x01, 0x15);
            L00F3: AddEncounter(party, 0x02, 0x17);
            L0105: AddEncounter(party, 0x03, 0x16);
            L0117: AddEncounter(party, 0x04, 0x18);
            L0129: return; // RETURN;
        }

        private void FnITEMCENC_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x64);
            L0011: if (JumpEqual) goto L0065;
            L0013: ax = HasItem(party, 0x94);
            L0021: if (JumpEqual) goto L0044;
            L0023: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xBD);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x94);
            L0063: goto L00B6;
            L0065: ax = HasItem(party, 0x94);
            L0073: if (JumpEqual) goto L0096;
            L0075: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x64);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x64, 0x94);
            L00B6: ShowMessage(party, String0653); // Reptilian bodies stir as you draw near.
            L00C3: Compare(PartyCount(party), 0x0001);
            L00CE: if (JumpNotEqual) goto L00E5;
            L00D0: AddEncounter(party, 0x01, 0x23);
            L00E2: goto L017F;
            L00E5: Compare(PartyCount(party), 0x0002);
            L00F0: if (JumpEqual) goto L00FF;
            L00F2: Compare(PartyCount(party), 0x0003);
            L00FD: if (JumpNotEqual) goto L0137;
            L00FF: AddEncounter(party, 0x01, 0x23);
            L0111: AddEncounter(party, 0x02, 0x23);
            L0123: AddEncounter(party, 0x03, 0x23);
            L0135: goto L017F;
            L0137: AddEncounter(party, 0x01, 0x23);
            L0149: AddEncounter(party, 0x02, 0x23);
            L015B: AddEncounter(party, 0x03, 0x23);
            L016D: AddEncounter(party, 0x04, 0x23);
            L017F: return; // RETURN;
        }

        private void FnSTRMNSTR_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(party, 0x01, 0x19);
            L0022: AddEncounter(party, 0x02, 0x1A);
            L0034: goto L0152;
            L0037: Compare(PartyCount(party), 0x0002);
            L0042: if (JumpNotEqual) goto L007D;
            L0044: AddEncounter(party, 0x01, 0x19);
            L0056: AddEncounter(party, 0x02, 0x1A);
            L0068: AddEncounter(party, 0x03, 0x19);
            L007A: goto L0152;
            L007D: Compare(PartyCount(party), 0x0003);
            L0088: if (JumpNotEqual) goto L00E6;
            L008A: AddEncounter(party, 0x01, 0x1A);
            L009C: AddEncounter(party, 0x02, 0x1A);
            L00AE: AddEncounter(party, 0x03, 0x1B);
            L00C0: AddEncounter(party, 0x04, 0x1B);
            L00D2: AddEncounter(party, 0x05, 0x1C);
            L00E4: goto L0152;
            L00E6: AddEncounter(party, 0x01, 0x1B);
            L00F8: AddEncounter(party, 0x02, 0x1B);
            L010A: AddEncounter(party, 0x03, 0x1B);
            L011C: AddEncounter(party, 0x04, 0x1B);
            L012E: AddEncounter(party, 0x05, 0x1C);
            L0140: AddEncounter(party, 0x06, 0x1C);
            L0152: return; // RETURN;
        }

        private void FnTUFMNSTR_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(party, 0x01, 0x21);
            L0022: goto L010A;
            L0025: Compare(PartyCount(party), 0x0002);
            L0030: if (JumpNotEqual) goto L0059;
            L0032: AddEncounter(party, 0x01, 0x21);
            L0044: AddEncounter(party, 0x02, 0x21);
            L0056: goto L010A;
            L0059: Compare(PartyCount(party), 0x0003);
            L0064: if (JumpNotEqual) goto L00B0;
            L0066: AddEncounter(party, 0x01, 0x21);
            L0078: AddEncounter(party, 0x02, 0x21);
            L008A: AddEncounter(party, 0x03, 0x21);
            L009C: AddEncounter(party, 0x04, 0x21);
            L00AE: goto L010A;
            L00B0: AddEncounter(party, 0x01, 0x21);
            L00C2: AddEncounter(party, 0x02, 0x21);
            L00D4: AddEncounter(party, 0x03, 0x21);
            L00E6: AddEncounter(party, 0x04, 0x21);
            L00F8: AddEncounter(party, 0x05, 0x21);
            L010A: return; // RETURN;
        }

        private void FnSTRSMESS_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String067B); // The stairs through the west gateway lead down a level.
            L0010: return; // RETURN;
        }

        private void FnNPCCHATA_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06B2); // A Human Wizard teleports into the room you occupy.
            L0010: ShowPortrait(party, 0x002B);
            L001D: Compare(GetRandom(party, 0x000F), 0x000B);
            L002D: if (JumpAbove) goto L0058;
            L002F: ShowMessage(party, String06E5); // Be careful when you find the way to open the door that leads to the nether depths of this dungeon.
            L003C: ShowMessage(party, String0748); // All quest items from Cleowyn's Palace levels will be stripped from you.
            L0049: ShowMessage(party, String0790); // But if you are indeed ready to enter the lower depths, you will no longer need Cleowyn's toys.
            L0056: goto L0065;
            L0058: ShowMessage(party, String07EF); // The Human Wizard smiles sheepishly and teleports somewhere else.
            L0065: return; // RETURN;
        }

        private void FnNPCCHATB_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0830); // You encounter a sleepy Troll Knight.
            L0010: ShowPortrait(party, 0x001B);
            L001D: Compare(GetRandom(party, 0x000F), 0x0009);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(party, String0855); // The Galabryan kings brought the great wizard Arnakkian Slowfoot to Twinion. The island grew famous and rich thanks to this wizard.
            L003C: ShowMessage(party, String08D8); // But the wizard had his own schemes, and soon he and good King Leowyn Galabryan were at loggerheads. Supposedly, the wizard had the king assassinated.
            L0049: goto L0058;
            L004B: ShowMessage(party, String096E); // The Troll Knight blinks at you dumbly and falls asleep.
            L0058: return; // RETURN;
        }

    }
}
