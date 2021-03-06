#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap21 : AMapScripted {
        protected override int MapIndex => 21;
        
        public YserMap21() {
            MapEvent01 = FnPIT_01;
            MapEvent02 = FnENCGUARD_02;
            MapEvent03 = FnENCEARTH_03;
            MapEvent04 = FnGUARDIAN_04;
            MapEvent05 = FnEARTHELE_05;
            MapEvent06 = FnPLATA_06;
            MapEvent07 = FnPLATB_07;
            MapEvent08 = FnYBOXA_08;
            MapEvent09 = FnYBOXB_09;
            MapEvent0A = FnYBOXC_0A;
            MapEvent0B = FnYBOXD_0B;
            MapEvent0C = FnYBOXE_0C;
            MapEvent0D = FnYBOXF_0D;
            MapEvent0E = FnXBOXG_0E;
            MapEvent0F = FnXBOXH_0F;
            MapEvent10 = FnXBOXI_10;
            MapEvent11 = FnXBOXJ_11;
            MapEvent12 = FnXBOXK_12;
            MapEvent13 = FnXBOXL_13;
            MapEvent14 = FnXBOXM_14;
            MapEvent15 = FnPITAJ_15;
            MapEvent16 = FnPITAK_16;
            MapEvent17 = FnPITAL_17;
            MapEvent18 = FnPITAM_18;
            MapEvent19 = FnPITBG_19;
            MapEvent1A = FnPITBI_1A;
            MapEvent1B = FnPITBJ_1B;
            MapEvent1C = FnPITBK_1C;
            MapEvent1D = FnPITBL_1D;
            MapEvent1E = FnPITBM_1E;
            MapEvent1F = FnPITCG_1F;
            MapEvent20 = FnPITCH_20;
            MapEvent21 = FnPITCI_21;
            MapEvent22 = FnPITCJ_22;
            MapEvent23 = FnPITCK_23;
            MapEvent24 = FnPITCL_24;
            MapEvent25 = FnPITCM_25;
            MapEvent26 = FnPITDG_26;
            MapEvent27 = FnPITDH_27;
            MapEvent28 = FnPITDI_28;
            MapEvent29 = FnPITDJ_29;
            MapEvent2A = FnPITDK_2A;
            MapEvent2B = FnPITDL_2B;
            MapEvent2C = FnPITDM_2C;
            MapEvent2D = FnPITEG_2D;
            MapEvent2E = FnPITEH_2E;
            MapEvent2F = FnPITEI_2F;
            MapEvent30 = FnPITEJ_30;
            MapEvent31 = FnPITEK_31;
            MapEvent32 = FnPITFG_32;
            MapEvent33 = FnPITFH_33;
            MapEvent34 = FnPITFI_34;
            MapEvent35 = FnPITFJ_35;
            MapEvent36 = FnPITFK_36;
            MapEvent37 = FnPITFL_37;
            MapEvent38 = FnPITFM_38;
            MapEvent39 = FnENCPITBJ_39;
            MapEvent3A = FnENCPITDI_3A;
            MapEvent3B = FnPITENCDK_3B;
            MapEvent3C = FnPITENCBL_3C;
            MapEvent3D = FnDOORARNK_3D;
            MapEvent3E = FnTELEARNK_3E;
            MapEvent3F = FnSETEKILL_3F;
        }
        
        // === Strings ================================================
        private const string String03FC = "You step into a bottomless pit and die.";
        private const string String0424 = "Guardians stand ready.  'We are sworn to defend Arnakkian.'";
        private const string String0460 = "Earth Elemental Andreas rises from his mountainous perch.";
        private const string String049A = "Enlikil's Phantasm Guardians stand watch over the entrance to Arnakkian's Tomb.";
        private const string String04EA = "The earth elemental palace is filled with a bounty of priceless gems.  It seems to shake with great power.";
        private const string String0555 = "The Endless Void has ruptured your dimensionand forms a chasm between here and a distant platform.";
        private const string String05B8 = "A voice whispers 'Only true friendship can bridge the gap of time.'";
        private const string String05FC = "Quiet solitude fills the chasm.  You are on the other side.";
        private const string String0638 = "The wall glows.";
        private const string String0648 = "The wall glows.";
        private const string String0658 = "The wall glows.";
        private const string String0668 = "The wall glows.";
        private const string String0678 = "The wall glows.";
        private const string String0688 = "The wall glows.";
        private const string String0698 = "The wall glows.";
        private const string String06A8 = "The wall glows.";
        private const string String06B8 = "The wall glows.";
        private const string String06C8 = "The wall glows.";
        private const string String06D8 = "The wall glows.";
        private const string String06E8 = "The wall glows.";
        private const string String06F8 = "The wall glows.";
        private const string String0708 = "Your decision on where to step next saves you.";
        private const string String0737 = "You step over the edge and into oblivion.";
        private const string String0761 = "You selected your next move wisely.";
        private const string String0785 = "You step over the edge and into oblivion.";
        private const string String07AF = "Your next step is a safe one.";
        private const string String07CD = "You step over the edge and into oblivion.";
        private const string String07F7 = "The step you take is wisely chosen.";
        private const string String081B = "You step over the edge and into oblivion.";
        private const string String0845 = "You take one good step forward.";
        private const string String0865 = "You step over the edge and into oblivion.";
        private const string String088F = "You safely step forward.";
        private const string String08A8 = "You step over the edge and into oblivion.";
        private const string String08D2 = "You take a step in the right direction,";
        private const string String08FA = "You step over the edge and into oblivion.";
        private const string String0924 = "Your move is wise.";
        private const string String0937 = "You step over the edge and into oblivion.";
        private const string String0961 = "You select your next move wisely.";
        private const string String0983 = "You step over the edge and into oblivion.";
        private const string String09AD = "You move forward with confidence.";
        private const string String09CF = "You step over the edge and into oblivion.";
        private const string String09F9 = "Your next step is a good one.";
        private const string String0A17 = "You step over the edge and into oblivion.";
        private const string String0A41 = "You move ahead assuredly.";
        private const string String0A5B = "You step over the edge and into oblivion.";
        private const string String0A85 = "You choose your next step correctly.";
        private const string String0AAA = "You step over the edge and into oblivion.";
        private const string String0AD4 = "Your choice of movement saves you.";
        private const string String0AF7 = "You step over the edge and into oblivion.";
        private const string String0B21 = "You step in the right direction.";
        private const string String0B42 = "You step over the edge and into oblivion.";
        private const string String0B6C = "You select your next step wisely.";
        private const string String0B8E = "You step over the edge and into oblivion.";
        private const string String0BB8 = "Your next step is sagely chosen.";
        private const string String0BD9 = "You step over the edge and into oblivion.";
        private const string String0C03 = "You take a wise step forward.";
        private const string String0C21 = "You step over the edge and into oblivion.";
        private const string String0C4B = "You move forward wisely.";
        private const string String0C64 = "You step over the edge and into oblivion.";
        private const string String0C8E = "Your next step is wisely decided.";
        private const string String0CB0 = "You step over the edge and into oblivion.";
        private const string String0CDA = "You step ahead with confidence.";
        private const string String0CFA = "You step over the edge and into oblivion.";
        private const string String0D24 = "You move forward carefully.";
        private const string String0D40 = "You step over the edge and into oblivion.";
        private const string String0D6A = "You move ahead.";
        private const string String0D7A = "You step over the edge and into oblivion.";
        private const string String0DA4 = "Your step is wisely selected.";
        private const string String0DC2 = "You step over the edge and into oblivion.";
        private const string String0DEC = "You forge ahead.";
        private const string String0DFD = "You step over the edge and into oblivion.";
        private const string String0E27 = "You select your next move wisely.";
        private const string String0E49 = "You step over the edge and into oblivion.";
        private const string String0E73 = "Good sense guides your feet.";
        private const string String0E90 = "You step over the edge and into oblivion.";
        private const string String0EBA = "You walk ahead.";
        private const string String0ECA = "You step over the edge and into oblivion.";
        private const string String0EF4 = "Your next step is assuredly taken.";
        private const string String0F17 = "You step over the edge and into oblivion.";
        private const string String0F41 = "The next step is an intelligent one.";
        private const string String0F66 = "You step over the edge and into oblivion.";
        private const string String0F90 = "You move safely ahead.";
        private const string String0FA7 = "You step over the edge and into oblivion.";
        private const string String0FD1 = "Your movement decision was correct.";
        private const string String0FF5 = "You step over the edge and into oblivion.";
        private const string String101F = "You move forward with confidence.";
        private const string String1041 = "You step over the edge and into oblivion.";
        private const string String106B = "You carefully selected your next step.";
        private const string String1092 = "You step over the edge and into oblivion.";
        private const string String10BC = "You make a sage choice.";
        private const string String10D4 = "You step over the edge and into oblivion.";
        private const string String10FE = "You have made a wise decision.";
        private const string String111D = "You step over the edge and into oblivion.";
        private const string String1147 = "Andreas no longer defends this door.";
        private const string String116C = "The Earth Elemental holds power over this door.";
        private const string String119C = "A magic field grabs you and teleports you down into Arnakkian's tomb.  The laugh of an ancient archmage fills the chamber.";
        
        // === Functions ================================================
        private void FnPIT_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // You step into a bottomless pit and die.
            L0010: DamagePlayer(party, GetMaxHits(party));
            L0021: return; // RETURN;
        }

        private void FnENCGUARD_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0424); // Guardians stand ready.  'We are sworn to defend Arnakkian.'
            L0010: AddEncounter(party, 0x01, 0x27);
            L0022: AddEncounter(party, 0x02, 0x27);
            L0034: AddEncounter(party, 0x03, 0x27);
            L0046: AddEncounter(party, 0x04, 0x27);
            L0058: AddEncounter(party, 0x05, 0x27);
            L006A: RefreshCompareFlags(GetState(party, 0x02, 0x88));
            L007D: if (JumpNotEqual) goto L00A6;
            L007F: SetState(party, 0x02, 0x88, 0x01);
            L0094: AddExperience(party, 0x0007A120);
            L00A6: return; // RETURN;
        }

        private void FnENCEARTH_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetState(party, 0x01, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0123;
            L001B: ShowMessage(party, String0460); // Earth Elemental Andreas rises from his mountainous perch.
            L0028: AddEncounter(party, 0x01, 0x04);
            L003A: AddEncounter(party, 0x02, 0x04);
            L004C: AddEncounter(party, 0x03, 0x22);
            L005E: AddEncounter(party, 0x04, 0x0F);
            L0070: AddEncounter(party, 0x05, 0x23);
            L0082: AddEncounter(party, 0x06, 0x28);
            L0094: ax = HasItem(party, 0xE9);
            L00A2: if (JumpEqual) goto L00C6;
            L00A4: AddTreasure(party, 0x0000, 0x00, 0x00, 0x50, 0x50, 0xD0);
            L00C4: goto L0123;
            L00C6: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x88, 0x1D, 0xE9);
            L00E7: RefreshCompareFlags(GetState(party, 0x02, 0x8A));
            L00FA: if (JumpNotEqual) goto L0123;
            L00FC: SetState(party, 0x02, 0x8A, 0x01);
            L0111: AddExperience(party, 0x0003D090);
            L0123: return; // RETURN;
        }

        private void FnGUARDIAN_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String049A); // Enlikil's Phantasm Guardians stand watch over the entrance to Arnakkian's Tomb.
            L0010: return; // RETURN;
        }

        private void FnEARTHELE_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetState(party, 0x01, 0x01));
            L0016: if (JumpNotEqual) goto L0025;
            L0018: ShowMessage(party, String04EA); // The earth elemental palace is filled with a bounty of priceless gems.  It seems to shake with great power.
            L0025: return; // RETURN;
        }

        private void FnPLATA_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0555); // The Endless Void has ruptured your dimensionand forms a chasm between here and a distant platform.
            L0010: ShowMessage(party, String05B8); // A voice whispers 'Only true friendship can bridge the gap of time.'
            L001D: return; // RETURN;
        }

        private void FnPLATB_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05FC); // Quiet solitude fills the chasm.  You are on the other side.
            L0010: return; // RETURN;
        }

        private void FnYBOXA_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0638); // The wall glows.
            L0010: SetState(party, 0x01, 0x02, 0x01);
            L0025: return; // RETURN;
        }

        private void FnYBOXB_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0648); // The wall glows.
            L0010: SetState(party, 0x01, 0x02, 0x02);
            L0025: return; // RETURN;
        }

        private void FnYBOXC_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0658); // The wall glows.
            L0010: SetState(party, 0x01, 0x02, 0x03);
            L0025: return; // RETURN;
        }

        private void FnYBOXD_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0668); // The wall glows.
            L0010: SetState(party, 0x01, 0x02, 0x04);
            L0025: return; // RETURN;
        }

        private void FnYBOXE_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0678); // The wall glows.
            L0010: SetState(party, 0x01, 0x02, 0x05);
            L0025: return; // RETURN;
        }

        private void FnYBOXF_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0688); // The wall glows.
            L0010: SetState(party, 0x01, 0x02, 0x06);
            L0025: return; // RETURN;
        }

        private void FnXBOXG_0E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0698); // The wall glows.
            L0010: SetState(party, 0x01, 0x03, 0x01);
            L0025: return; // RETURN;
        }

        private void FnXBOXH_0F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06A8); // The wall glows.
            L0010: SetState(party, 0x01, 0x03, 0x02);
            L0025: return; // RETURN;
        }

        private void FnXBOXI_10(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06B8); // The wall glows.
            L0010: SetState(party, 0x01, 0x03, 0x03);
            L0025: return; // RETURN;
        }

        private void FnXBOXJ_11(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06C8); // The wall glows.
            L0010: SetState(party, 0x01, 0x03, 0x04);
            L0025: return; // RETURN;
        }

        private void FnXBOXK_12(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06D8); // The wall glows.
            L0010: SetState(party, 0x01, 0x03, 0x05);
            L0025: return; // RETURN;
        }

        private void FnXBOXL_13(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06E8); // The wall glows.
            L0010: SetState(party, 0x01, 0x03, 0x06);
            L0025: return; // RETURN;
        }

        private void FnXBOXM_14(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06F8); // The wall glows.
            L0010: SetState(party, 0x01, 0x03, 0x07);
            L0025: return; // RETURN;
        }

        private void FnPITAJ_15(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0004);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0708); // Your decision on where to step next saves you.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0737); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITAK_16(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0005);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0761); // You selected your next move wisely.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0785); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITAL_17(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0006);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String07AF); // Your next step is a safe one.
            L003C: goto L005C;
            L003E: ShowMessage(party, String07CD); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITAM_18(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0007);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String07F7); // The step you take is wisely chosen.
            L003C: goto L005C;
            L003E: ShowMessage(party, String081B); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITBG_19(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0002);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0001);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0845); // You take one good step forward.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0865); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITBI_1A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0002);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0003);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String088F); // You safely step forward.
            L003C: goto L005C;
            L003E: ShowMessage(party, String08A8); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITBJ_1B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0002);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0004);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String08D2); // You take a step in the right direction,
            L003C: goto L005C;
            L003E: ShowMessage(party, String08FA); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITBK_1C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0002);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0005);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0924); // Your move is wise.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0937); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITBL_1D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0002);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0006);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0961); // You select your next move wisely.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0983); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITBM_1E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0002);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0007);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String09AD); // You move forward with confidence.
            L003C: goto L005C;
            L003E: ShowMessage(party, String09CF); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITCG_1F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0003);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0001);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String09F9); // Your next step is a good one.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0A17); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITCH_20(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0003);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0002);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0A41); // You move ahead assuredly.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0A5B); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITCI_21(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0003);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0003);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0A85); // You choose your next step correctly.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0AAA); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITCJ_22(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0003);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0004);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0AD4); // Your choice of movement saves you.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0AF7); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITCK_23(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0003);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0005);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0B21); // You step in the right direction.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0B42); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITCL_24(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0003);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0006);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0B6C); // You select your next step wisely.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0B8E); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITCM_25(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0003);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0007);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0BB8); // Your next step is sagely chosen.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0BD9); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITDG_26(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0004);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0001);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0C03); // You take a wise step forward.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0C21); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITDH_27(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0004);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0002);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0C4B); // You move forward wisely.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0C64); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITDI_28(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0004);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0003);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0C8E); // Your next step is wisely decided.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0CB0); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITDJ_29(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0004);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0004);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0CDA); // You step ahead with confidence.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0CFA); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITDK_2A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0004);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0005);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0D24); // You move forward carefully.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0D40); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITDL_2B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0004);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0006);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0D6A); // You move ahead.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0D7A); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITDM_2C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0004);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0007);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0DA4); // Your step is wisely selected.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0DC2); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITEG_2D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0005);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0001);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0DEC); // You forge ahead.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0DFD); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITEH_2E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0005);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0002);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0E27); // You select your next move wisely.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0E49); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITEI_2F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0005);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0003);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0E73); // Good sense guides your feet.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0E90); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITEJ_30(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0005);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0004);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0EBA); // You walk ahead.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0ECA); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITEK_31(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0005);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0005);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0EF4); // Your next step is assuredly taken.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0F17); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITFG_32(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0006);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0001);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0F41); // The next step is an intelligent one.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0F66); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITFH_33(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0006);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0002);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0F90); // You move safely ahead.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0FA7); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITFI_34(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0006);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0003);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String0FD1); // Your movement decision was correct.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0FF5); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITFJ_35(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0006);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0004);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String101F); // You move forward with confidence.
            L003C: goto L005C;
            L003E: ShowMessage(party, String1041); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITFK_36(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0006);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0005);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String106B); // You carefully selected your next step.
            L003C: goto L005C;
            L003E: ShowMessage(party, String1092); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITFL_37(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0006);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0006);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String10BC); // You make a sage choice.
            L003C: goto L005C;
            L003E: ShowMessage(party, String10D4); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnPITFM_38(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0006);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: Compare(GetState(party, 0x01, 0x03), 0x0007);
            L002D: if (JumpNotEqual) goto L003E;
            L002F: ShowMessage(party, String10FE); // You have made a wise decision.
            L003C: goto L005C;
            L003E: ShowMessage(party, String111D); // You step over the edge and into oblivion.
            L004B: DamagePlayer(party, GetMaxHits(party));
            L005C: return; // RETURN;
        }

        private void FnENCPITBJ_39(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x19);
            L0015: AddEncounter(party, 0x02, 0x1A);
            L0027: AddEncounter(party, 0x03, 0x1A);
            L0039: AddEncounter(party, 0x04, 0x1B);
            L004B: AddEncounter(party, 0x05, 0x1C);
            L005D: return; // RETURN;
        }

        private void FnENCPITDI_3A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x1F);
            L0027: AddEncounter(party, 0x03, 0x20);
            L0039: AddEncounter(party, 0x04, 0x20);
            L004B: return; // RETURN;
        }

        private void FnPITENCDK_3B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1B);
            L0015: AddEncounter(party, 0x02, 0x1B);
            L0027: AddEncounter(party, 0x03, 0x19);
            L0039: AddEncounter(party, 0x04, 0x19);
            L004B: AddEncounter(party, 0x05, 0x1B);
            L005D: AddEncounter(party, 0x06, 0x1B);
            L006F: return; // RETURN;
        }

        private void FnPITENCBL_3C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x24);
            L0015: AddEncounter(party, 0x02, 0x24);
            L0027: AddEncounter(party, 0x03, 0x24);
            L0039: AddEncounter(party, 0x04, 0x25);
            L004B: AddEncounter(party, 0x05, 0x26);
            L005D: return; // RETURN;
        }

        private void FnDOORARNK_3D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetState(party, 0x01, 0x01));
            L0016: if (JumpEqual) goto L005B;
            L0018: SetWallPassable(party, GetCurrentTile(party), 0x03, 0x01);
            L0032: SetWallObject(party, 0x01, GetCurrentTile(party), 0x03);
            L004C: ShowMessage(party, String1147); // Andreas no longer defends this door.
            L0059: goto L0068;
            L005B: ShowMessage(party, String116C); // The Earth Elemental holds power over this door.
            L0068: return; // RETURN;
        }

        private void FnTELEARNK_3E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String119C); // A magic field grabs you and teleports you down into Arnakkian's tomb.  The laugh of an ancient archmage fills the chamber.
            L0010: TeleportParty(party, 0x34, 0x02, 0x76, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnSETEKILL_3F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState(party, 0x01, 0x01, 0x01);
            L0018: return; // RETURN;
        }

    }
}
