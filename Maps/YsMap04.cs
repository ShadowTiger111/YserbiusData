#pragma warning disable
using ZCF.WorldData;

namespace ZCF.Scripts.Maps {
    class YserMap04 : AMapScript {
        // === Strings ================================================
        private const string String03FC = "There is a teleport in the north wall to the Hall of Doors.";
        private const string String0438 = "The gateway leads to the SOLDIERS QUARTERS.";
        private const string String0464 = "You encounter a Human Thief.";
        private const string String0481 = "King Cleowyn long sought the buried secrets of a great wizard whose castle lies buried inside this mountain. ";
        private const string String04EF = "The king died most horribly, it is said. His anguished death scream was heard across the island, but no one ever found his body. The dead wizard may have claimed the body, but no one knows for sure.";
        private const string String05B6 = "The Human Thief cadges some money from you and runs away.";
        private const string String05F0 = "You encounter an Elf Barbarian.";
        private const string String0610 = "Two levels down is a most strange area. Six small rooms are accessible to anyone, but there is a large area I have not been able to reach. A wizard told me I should study my runes to solve the mystery of this area.";
        private const string String06E7 = "The Elf Barbarian is busy tending her many wounds and ignores you.";
        private const string String072A = "Monsters jump out of the shadows.";
        private const string String074C = "Monsters snarl as you approach a pile of weapons.";
        private const string String077E = "Unclean spirits shriek as they attack.";
        private const string String07A5 = "Incubi surround you as you approach a weapon on the floor.";
        private const string String07E0 = "Skeletons attack you.";
        private const string String07F6 = "Skeletons guard a precious hoard.";
        private const string String0818 = "The dead arise as you draw near.";
        private const string String0839 = "Your movement disturbs the dead who have guarded King Cleowyn's Treasury.";
        private const string String0883 = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String08D3 = "A trapdoor in the floor opens.";
        private const string String08F2 = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0942 = "A trapdoor in the floor opens.";
        private const string String0961 = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String09B1 = "A trapdoor in the floor opens.";
        private const string String09D0 = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0A20 = "A trapdoor in the floor opens.";
        private const string String0A3F = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0A8F = "A trapdoor in the floor opens.";
        private const string String0AAE = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0AFE = "A trapdoor in the floor opens.";
        private const string String0B1D = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0B6D = "A trapdoor in the floor opens.";
        private const string String0B8C = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0BDC = "A trapdoor in the floor opens.";
        private const string String0BFB = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0C4B = "A trapdoor in the floor opens.";
        private const string String0C6A = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0CBA = "A trapdoor in the floor opens.";
        private const string String0CD9 = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0D29 = "A trapdoor in the floor opens.";
        private const string String0D48 = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0D98 = "A trapdoor in the floor opens.";
        private const string String0DB7 = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0E07 = "A trapdoor in the floor opens.";
        private const string String0E26 = "You detect a trapdoor in the floor, but not in time to prevent falling through!";
        private const string String0E76 = "A trapdoor in the floor opens.";
        private const string String0E95 = "Ghosts haunt the empty room.";
        private const string String0EB2 = "Spirits of the dead guard King Cleowyn's gold.";
        private const string String0EE1 = "Bones of dead guards and one-time thieves rise to challenge you.";
        private const string String0F22 = "Skeletons of dead guards and the thieves they killed stand between you and Cleowyn's gold.";
        private const string String0F7D = "Spiders drop from the ceiling.";
        private const string String0F9C = "Spider webs envelop a pile of gold pieces on the floor.";
        
        // === Functions ================================================
        protected override MapEventHandler MapEvent01 => FnTELPORTN_01;
        private void FnTELPORTN_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x04, 0x5F, 0x01);
            L001E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent02 => FnTELEMESG_02;
        private void FnTELEMESG_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // There is a teleport in the north wall to the Hall of Doors.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent03 => FnTOSOLDQU_03;
        private void FnTOSOLDQU_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x06, 0x4F, 0x00);
            L001D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent04 => FnGATEMESG_04;
        private void FnGATEMESG_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0438); // The gateway leads to the SOLDIERS QUARTERS.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent05 => FnNPCCHATA_05;
        private void FnNPCCHATA_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0464); // You encounter a Human Thief.
            L0010: ShowPortrait(party, 0x0022);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: Compare(ax, 0x0009);
            L002D: if (CompareResultUnsignedGreaterThan) goto L004B;
            L002F: ShowMessage(party, String0481); // King Cleowyn long sought the buried secrets of a great wizard whose castle lies buried inside this mountain. 
            L003C: ShowMessage(party, String04EF); // The king died most horribly, it is said. His anguished death scream was heard across the island, but no one ever found his body. The dead wizard may have claimed the body, but no one knows for sure.
            L0049: goto L006A;
            L004B: ModifyGold(party, 0xFFFF38BA);
            L005D: ShowMessage(party, String05B6); // The Human Thief cadges some money from you and runs away.
            L006A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent06 => FnNPCCHATB_06;
        private void FnNPCCHATB_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05F0); // You encounter an Elf Barbarian.
            L0010: ShowPortrait(party, 0x0018);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: Compare(ax, 0x0007);
            L002D: if (CompareResultUnsignedGreaterThan) goto L003E;
            L002F: ShowMessage(party, String0610); // Two levels down is a most strange area. Six small rooms are accessible to anyone, but there is a large area I have not been able to reach. A wizard told me I should study my runes to solve the mystery of this area.
            L003C: goto L004B;
            L003E: ShowMessage(party, String06E7); // The Elf Barbarian is busy tending her many wounds and ignores you.
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent07 => FnITEMAENC_07;
        private void FnITEMAENC_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x12);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L0048;
            L0019: ShowMessage(party, String072A); // Monsters jump out of the shadows.
            L0026: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCE, 0xB5);
            L0046: goto L008B;
            L0048: AddTreasure(party, 0x1770, 0x00, 0x00, 0xCE, 0x42, 0x0A);
            L0069: SetState00(party, 0x02, 0x12, 0x01);
            L007E: ShowMessage(party, String074C); // Monsters snarl as you approach a pile of weapons.
            L008B: ax = PartyCount(party);
            L0093: Compare(ax, 0x0001);
            L0096: if (CompareResultEqual) goto L00A5;
            L0098: ax = PartyCount(party);
            L00A0: Compare(ax, 0x0002);
            L00A3: if (!CompareResultEqual) goto L00CB;
            L00A5: AddEncounter(party, 0x01, 0x19);
            L00B7: AddEncounter(party, 0x02, 0x1E);
            L00C9: goto L0125;
            L00CB: AddEncounter(party, 0x01, 0x1B);
            L00DD: AddEncounter(party, 0x02, 0x1A);
            L00EF: AddEncounter(party, 0x03, 0x19);
            L0101: AddEncounter(party, 0x05, 0x1E);
            L0113: AddEncounter(party, 0x06, 0x1E);
            L0125: return; // RETURN;
        }

        protected override MapEventHandler MapEvent08 => FnTELPORTN_08;
        private void FnTELPORTN_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x04, 0x5F, 0x01);
            L001E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent09 => FnITEMBENC_09;
        private void FnITEMBENC_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x13);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L0048;
            L0019: ShowMessage(party, String077E); // Unclean spirits shriek as they attack.
            L0026: AddTreasure(party, 0x0190, 0x00, 0x00, 0x00, 0xB5, 0xCB);
            L0046: goto L008A;
            L0048: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0x8A, 0x3B);
            L0068: SetState00(party, 0x02, 0x13, 0x01);
            L007D: ShowMessage(party, String07A5); // Incubi surround you as you approach a weapon on the floor.
            L008A: ax = PartyCount(party);
            L0092: Compare(ax, 0x0001);
            L0095: if (!CompareResultEqual) goto L00BE;
            L0097: AddEncounter(party, 0x01, 0x24);
            L00A9: AddEncounter(party, 0x02, 0x24);
            L00BB: goto L0181;
            L00BE: ax = PartyCount(party);
            L00C6: Compare(ax, 0x0002);
            L00C9: if (!CompareResultEqual) goto L0115;
            L00CB: AddEncounter(party, 0x01, 0x23);
            L00DD: AddEncounter(party, 0x02, 0x23);
            L00EF: AddEncounter(party, 0x03, 0x23);
            L0101: AddEncounter(party, 0x04, 0x25);
            L0113: goto L0181;
            L0115: AddEncounter(party, 0x01, 0x28);
            L0127: AddEncounter(party, 0x02, 0x28);
            L0139: AddEncounter(party, 0x03, 0x27);
            L014B: AddEncounter(party, 0x04, 0x27);
            L015D: AddEncounter(party, 0x05, 0x26);
            L016F: AddEncounter(party, 0x06, 0x26);
            L0181: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0A => FnITEMCENC_0A;
        private void FnITEMCENC_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x14);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L0047;
            L0019: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0038: ShowMessage(party, String07E0); // Skeletons attack you.
            L0045: goto L008B;
            L0047: AddTreasure(party, 0x0BB8, 0x00, 0xCC, 0x39, 0x8C, 0x1C);
            L0069: SetState00(party, 0x02, 0x14, 0x01);
            L007E: ShowMessage(party, String07F6); // Skeletons guard a precious hoard.
            L008B: ax = PartyCount(party);
            L0093: Compare(ax, 0x0001);
            L0096: if (!CompareResultEqual) goto L00BF;
            L0098: AddEncounter(party, 0x01, 0x03);
            L00AA: AddEncounter(party, 0x02, 0x02);
            L00BC: goto L01DA;
            L00BF: ax = PartyCount(party);
            L00C7: Compare(ax, 0x0002);
            L00CA: if (!CompareResultEqual) goto L0105;
            L00CC: AddEncounter(party, 0x01, 0x03);
            L00DE: AddEncounter(party, 0x02, 0x01);
            L00F0: AddEncounter(party, 0x03, 0x03);
            L0102: goto L01DA;
            L0105: ax = PartyCount(party);
            L010D: Compare(ax, 0x0003);
            L0110: if (!CompareResultEqual) goto L016E;
            L0112: AddEncounter(party, 0x01, 0x04);
            L0124: AddEncounter(party, 0x02, 0x02);
            L0136: AddEncounter(party, 0x03, 0x04);
            L0148: AddEncounter(party, 0x04, 0x03);
            L015A: AddEncounter(party, 0x06, 0x01);
            L016C: goto L01DA;
            L016E: AddEncounter(party, 0x01, 0x04);
            L0180: AddEncounter(party, 0x02, 0x04);
            L0192: AddEncounter(party, 0x03, 0x03);
            L01A4: AddEncounter(party, 0x04, 0x03);
            L01B6: AddEncounter(party, 0x05, 0x02);
            L01C8: AddEncounter(party, 0x06, 0x02);
            L01DA: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0B => FnITEMDENC_0B;
        private void FnITEMDENC_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x15);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L0047;
            L0019: ShowMessage(party, String0818); // The dead arise as you draw near.
            L0026: AddTreasure(party, 0x0096, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0045: goto L0089;
            L0047: AddTreasure(party, 0x09C4, 0x00, 0x00, 0x00, 0xC2, 0x76);
            L0067: SetState00(party, 0x02, 0x15, 0x01);
            L007C: ShowMessage(party, String0839); // Your movement disturbs the dead who have guarded King Cleowyn's Treasury.
            L0089: ax = PartyCount(party);
            L0091: Compare(ax, 0x0001);
            L0094: if (!CompareResultEqual) goto L00BD;
            L0096: AddEncounter(party, 0x01, 0x08);
            L00A8: AddEncounter(party, 0x02, 0x0D);
            L00BA: goto L016E;
            L00BD: ax = PartyCount(party);
            L00C5: Compare(ax, 0x0002);
            L00C8: if (!CompareResultEqual) goto L0102;
            L00CA: AddEncounter(party, 0x01, 0x09);
            L00DC: AddEncounter(party, 0x02, 0x0E);
            L00EE: AddEncounter(party, 0x03, 0x06);
            L0100: goto L016E;
            L0102: AddEncounter(party, 0x01, 0x0B);
            L0114: AddEncounter(party, 0x02, 0x0A);
            L0126: AddEncounter(party, 0x03, 0x05);
            L0138: AddEncounter(party, 0x04, 0x06);
            L014A: AddEncounter(party, 0x05, 0x12);
            L015C: AddEncounter(party, 0x06, 0x13);
            L016E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0D => FnTRAPDORA_0D;
        private void FnTRAPDORA_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0005);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L0063;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L0063;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L0063;
            L0039: ax = UsedItem54(party, 0xBD, 0xBD);
            L004C: if (!CompareResultEqual) goto L0063;
            L004E: ax = UsedItem54(party, 0xBE, 0xBE);
            L0061: if (CompareResultEqual) goto L008D;
            L0063: ShowMessage(party, String0883); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L0070: SetMoveMap(party, 0x02, 0x01, 0x85, 0x01);
            L008B: goto L00B5;
            L008D: ShowMessage(party, String08D3); // A trapdoor in the floor opens.
            L009A: SetMoveMap(party, 0x02, 0x01, 0x85, 0x01);
            L00B5: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0E => FnTRAPDORB_0E;
        private void FnTRAPDORB_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0005);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L0063;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L0063;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L0063;
            L0039: ax = UsedItem54(party, 0xBD, 0xBD);
            L004C: if (!CompareResultEqual) goto L0063;
            L004E: ax = UsedItem54(party, 0xBE, 0xBE);
            L0061: if (CompareResultEqual) goto L008D;
            L0063: ShowMessage(party, String08F2); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L0070: SetMoveMap(party, 0x02, 0x01, 0x86, 0x01);
            L008B: goto L00B5;
            L008D: ShowMessage(party, String0942); // A trapdoor in the floor opens.
            L009A: SetMoveMap(party, 0x02, 0x01, 0x86, 0x01);
            L00B5: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0F => FnTRAPDORC_0F;
        private void FnTRAPDORC_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0006);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L0063;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L0063;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L0063;
            L0039: ax = UsedItem54(party, 0xBD, 0xBD);
            L004C: if (!CompareResultEqual) goto L0063;
            L004E: ax = UsedItem54(party, 0xBE, 0xBE);
            L0061: if (CompareResultEqual) goto L008D;
            L0063: ShowMessage(party, String0961); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L0070: SetMoveMap(party, 0x02, 0x01, 0x98, 0x02);
            L008B: goto L00B5;
            L008D: ShowMessage(party, String09B1); // A trapdoor in the floor opens.
            L009A: SetMoveMap(party, 0x02, 0x01, 0x98, 0x02);
            L00B5: return; // RETURN;
        }

        protected override MapEventHandler MapEvent10 => FnTRAPDORD_10;
        private void FnTRAPDORD_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0006);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L0063;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L0063;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L0063;
            L0039: ax = UsedItem54(party, 0xBD, 0xBD);
            L004C: if (!CompareResultEqual) goto L0063;
            L004E: ax = UsedItem54(party, 0xBE, 0xBE);
            L0061: if (CompareResultEqual) goto L008C;
            L0063: ShowMessage(party, String09D0); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L0070: SetMoveMap(party, 0x02, 0x01, 0xA6, 0x00);
            L008A: goto L00B3;
            L008C: ShowMessage(party, String0A20); // A trapdoor in the floor opens.
            L0099: SetMoveMap(party, 0x02, 0x01, 0xA6, 0x00);
            L00B3: return; // RETURN;
        }

        protected override MapEventHandler MapEvent11 => FnTRAPDORE_11;
        private void FnTRAPDORE_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0007);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0077;
            L004E: ShowMessage(party, String0A3F); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L005B: SetMoveMap(party, 0x02, 0x01, 0xA8, 0x00);
            L0075: goto L009E;
            L0077: ShowMessage(party, String0A8F); // A trapdoor in the floor opens.
            L0084: SetMoveMap(party, 0x02, 0x01, 0xA8, 0x00);
            L009E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent12 => FnTRAPDORF_12;
        private void FnTRAPDORF_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0008);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0078;
            L004E: ShowMessage(party, String0AAE); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L005B: SetMoveMap(party, 0x02, 0x01, 0xB5, 0x02);
            L0076: goto L00A0;
            L0078: ShowMessage(party, String0AFE); // A trapdoor in the floor opens.
            L0085: SetMoveMap(party, 0x02, 0x01, 0xB5, 0x02);
            L00A0: return; // RETURN;
        }

        protected override MapEventHandler MapEvent13 => FnTRAPDORG_13;
        private void FnTRAPDORG_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0005);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L0063;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L0063;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L0063;
            L0039: ax = UsedItem54(party, 0xBD, 0xBD);
            L004C: if (!CompareResultEqual) goto L0063;
            L004E: ax = UsedItem54(party, 0xBE, 0xBE);
            L0061: if (CompareResultEqual) goto L008D;
            L0063: ShowMessage(party, String0B1D); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L0070: SetMoveMap(party, 0x02, 0x01, 0xC7, 0x01);
            L008B: goto L00B5;
            L008D: ShowMessage(party, String0B6D); // A trapdoor in the floor opens.
            L009A: SetMoveMap(party, 0x02, 0x01, 0xC7, 0x01);
            L00B5: return; // RETURN;
        }

        protected override MapEventHandler MapEvent14 => FnTRAPDORH_14;
        private void FnTRAPDORH_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0009);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0077;
            L004E: ShowMessage(party, String0B8C); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L005B: SetMoveMap(party, 0x02, 0x01, 0xCF, 0x00);
            L0075: goto L009E;
            L0077: ShowMessage(party, String0BDC); // A trapdoor in the floor opens.
            L0084: SetMoveMap(party, 0x02, 0x01, 0xCF, 0x00);
            L009E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent15 => FnTRAPDOR_15;
        private void FnTRAPDOR_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0006);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L0063;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L0063;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L0063;
            L0039: ax = UsedItem54(party, 0xBD, 0xBD);
            L004C: if (!CompareResultEqual) goto L0063;
            L004E: ax = UsedItem54(party, 0xBE, 0xBE);
            L0061: if (CompareResultEqual) goto L008C;
            L0063: ShowMessage(party, String0BFB); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L0070: SetMoveMap(party, 0x02, 0x01, 0xD6, 0x00);
            L008A: goto L00B3;
            L008C: ShowMessage(party, String0C4B); // A trapdoor in the floor opens.
            L0099: SetMoveMap(party, 0x02, 0x01, 0xD6, 0x00);
            L00B3: return; // RETURN;
        }

        protected override MapEventHandler MapEvent16 => FnTRAPDORJ_16;
        private void FnTRAPDORJ_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000A);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0078;
            L004E: ShowMessage(party, String0C6A); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L005B: SetMoveMap(party, 0x02, 0x01, 0xD8, 0x03);
            L0076: goto L00A0;
            L0078: ShowMessage(party, String0CBA); // A trapdoor in the floor opens.
            L0085: SetMoveMap(party, 0x02, 0x01, 0xD8, 0x03);
            L00A0: return; // RETURN;
        }

        protected override MapEventHandler MapEvent17 => FnTRAPDORK_17;
        private void FnTRAPDORK_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0006);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L0063;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L0063;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L0063;
            L0039: ax = UsedItem54(party, 0xBD, 0xBD);
            L004C: if (!CompareResultEqual) goto L0063;
            L004E: ax = UsedItem54(party, 0xBE, 0xBE);
            L0061: if (CompareResultEqual) goto L008D;
            L0063: ShowMessage(party, String0CD9); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L0070: SetMoveMap(party, 0x02, 0x01, 0xE9, 0x03);
            L008B: goto L00B5;
            L008D: ShowMessage(party, String0D29); // A trapdoor in the floor opens.
            L009A: SetMoveMap(party, 0x02, 0x01, 0xE9, 0x03);
            L00B5: return; // RETURN;
        }

        protected override MapEventHandler MapEvent18 => FnTRAPDORL_18;
        private void FnTRAPDORL_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000B);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0077;
            L004E: ShowMessage(party, String0D48); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L005B: SetMoveMap(party, 0x02, 0x01, 0xEB, 0x00);
            L0075: goto L009E;
            L0077: ShowMessage(party, String0D98); // A trapdoor in the floor opens.
            L0084: SetMoveMap(party, 0x02, 0x01, 0xEB, 0x00);
            L009E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent19 => FnTRAPDORM_19;
        private void FnTRAPDORM_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0008);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0077;
            L004E: ShowMessage(party, String0DB7); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L005B: SetMoveMap(party, 0x02, 0x01, 0xF5, 0x00);
            L0075: goto L009E;
            L0077: ShowMessage(party, String0E07); // A trapdoor in the floor opens.
            L0084: SetMoveMap(party, 0x02, 0x01, 0xF5, 0x00);
            L009E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1A => FnTRAPDORN_1A;
        private void FnTRAPDORN_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000A);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0078;
            L004E: ShowMessage(party, String0E26); // You detect a trapdoor in the floor, but not in time to prevent falling through!
            L005B: SetMoveMap(party, 0x02, 0x01, 0xF7, 0x02);
            L0076: goto L00A0;
            L0078: ShowMessage(party, String0E76); // A trapdoor in the floor opens.
            L0085: SetMoveMap(party, 0x02, 0x01, 0xF7, 0x02);
            L00A0: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1B => FnTUFMNSTR_1B;
        private void FnTUFMNSTR_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (CompareResultEqual) goto L001D;
            L0010: ax = PartyCount(party);
            L0018: Compare(ax, 0x0002);
            L001B: if (!CompareResultEqual) goto L0043;
            L001D: AddEncounter(party, 0x01, 0x1A);
            L002F: AddEncounter(party, 0x02, 0x1A);
            L0041: goto L009D;
            L0043: AddEncounter(party, 0x01, 0x1D);
            L0055: AddEncounter(party, 0x02, 0x1D);
            L0067: AddEncounter(party, 0x03, 0x1C);
            L0079: AddEncounter(party, 0x04, 0x1E);
            L008B: AddEncounter(party, 0x05, 0x1E);
            L009D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1E => FnGOLDENCA_1E;
        private void FnGOLDENCA_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x09);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L0046;
            L0019: ShowMessage(party, String0E95); // Ghosts haunt the empty room.
            L0026: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x73);
            L0044: goto L0087;
            L0046: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0065: SetState00(party, 0x02, 0x09, 0x01);
            L007A: ShowMessage(party, String0EB2); // Spirits of the dead guard King Cleowyn's gold.
            L0087: ax = PartyCount(party);
            L008F: Compare(ax, 0x0001);
            L0092: if (CompareResultEqual) goto L00A1;
            L0094: ax = PartyCount(party);
            L009C: Compare(ax, 0x0002);
            L009F: if (!CompareResultEqual) goto L00C7;
            L00A1: AddEncounter(party, 0x01, 0x0F);
            L00B3: AddEncounter(party, 0x02, 0x10);
            L00C5: goto L010F;
            L00C7: AddEncounter(party, 0x01, 0x10);
            L00D9: AddEncounter(party, 0x02, 0x11);
            L00EB: AddEncounter(party, 0x03, 0x11);
            L00FD: AddEncounter(party, 0x04, 0x10);
            L010F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1F => FnGOLDBENC_1F;
        private void FnGOLDBENC_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x0A);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L0047;
            L0019: ShowMessage(party, String0EE1); // Bones of dead guards and one-time thieves rise to challenge you.
            L0026: AddTreasure(party, 0x00FA, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0066: SetState00(party, 0x02, 0x0A, 0x01);
            L007B: ShowMessage(party, String0F22); // Skeletons of dead guards and the thieves they killed stand between you and Cleowyn's gold.
            L0088: ax = PartyCount(party);
            L0090: Compare(ax, 0x0001);
            L0093: if (!CompareResultEqual) goto L00BC;
            L0095: AddEncounter(party, 0x01, 0x03);
            L00A7: AddEncounter(party, 0x02, 0x02);
            L00B9: goto L01D7;
            L00BC: ax = PartyCount(party);
            L00C4: Compare(ax, 0x0002);
            L00C7: if (!CompareResultEqual) goto L0102;
            L00C9: AddEncounter(party, 0x01, 0x03);
            L00DB: AddEncounter(party, 0x02, 0x01);
            L00ED: AddEncounter(party, 0x03, 0x03);
            L00FF: goto L01D7;
            L0102: ax = PartyCount(party);
            L010A: Compare(ax, 0x0003);
            L010D: if (!CompareResultEqual) goto L016B;
            L010F: AddEncounter(party, 0x01, 0x04);
            L0121: AddEncounter(party, 0x02, 0x02);
            L0133: AddEncounter(party, 0x03, 0x04);
            L0145: AddEncounter(party, 0x04, 0x03);
            L0157: AddEncounter(party, 0x06, 0x01);
            L0169: goto L01D7;
            L016B: AddEncounter(party, 0x01, 0x04);
            L017D: AddEncounter(party, 0x02, 0x04);
            L018F: AddEncounter(party, 0x03, 0x03);
            L01A1: AddEncounter(party, 0x04, 0x03);
            L01B3: AddEncounter(party, 0x05, 0x02);
            L01C5: AddEncounter(party, 0x06, 0x02);
            L01D7: return; // RETURN;
        }

        protected override MapEventHandler MapEvent20 => FnGOLDCENC_20;
        private void FnGOLDCENC_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x0B);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L0047;
            L0019: ShowMessage(party, String0F7D); // Spiders drop from the ceiling.
            L0026: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xBD);
            L0066: SetState00(party, 0x02, 0x0B, 0x01);
            L007B: ShowMessage(party, String0F9C); // Spider webs envelop a pile of gold pieces on the floor.
            L0088: ax = PartyCount(party);
            L0090: Compare(ax, 0x0001);
            L0093: if (!CompareResultEqual) goto L00BC;
            L0095: AddEncounter(party, 0x01, 0x16);
            L00A7: AddEncounter(party, 0x02, 0x16);
            L00B9: goto L015B;
            L00BC: ax = PartyCount(party);
            L00C4: Compare(ax, 0x0002);
            L00C7: if (!CompareResultEqual) goto L0101;
            L00C9: AddEncounter(party, 0x01, 0x17);
            L00DB: AddEncounter(party, 0x02, 0x16);
            L00ED: AddEncounter(party, 0x03, 0x17);
            L00FF: goto L015B;
            L0101: AddEncounter(party, 0x01, 0x16);
            L0113: AddEncounter(party, 0x02, 0x16);
            L0125: AddEncounter(party, 0x03, 0x17);
            L0137: AddEncounter(party, 0x04, 0x17);
            L0149: AddEncounter(party, 0x05, 0x18);
            L015B: return; // RETURN;
        }

    }
}