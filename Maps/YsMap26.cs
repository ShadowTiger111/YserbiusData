namespace ZCF.Scripts.Maps {
    class YserMap26 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "You stumble into the lava river and die.";
        private const string String0425 = "This gate leads to the entrance of Arnakkian's Arena.";
        private const string String045B = "Of all the winds, the TEMPEST is the most violent and dangerous.";
        private const string String049C = "Enter HEAVEN'S FURY if you must.  It is here Voranti cursed the winds.";
        private const string String04E3 = "A doorway leads to the town of Castlegate, a village just outside Arnakkian's Castle.";
        private const string String0539 = "It is rumored that a band of dwarves once lived behind the doors of LookOut.";
        private const string String0586 = "With a massive effort, you manage to force the door open.";
        private const string String05C0 = "The door is stuck and will not open.";
        private const string String05E5 = "A plaque reads..";
        private const string String05F6 = "'Thanks to the gracious generosity of the Mage Council, the survivors of the Arnakkian disaster hereby proclaim a new teleport to the top.'";
        private const string String0682 = "Fighting the raging River of Eternity taps your life energy.";
        private const string String06BF = "You have died.";
        private const string String06CE = "The Phoenix is being reborn and may not be disturbed.";
        private const string String0704 = "Ahead, bound by the River of Eternity, is the shadow of the Phoenix Firebird. ";
        private const string String0753 = "The raging waters of the river look daunting.";
        private const string String0781 = "You hear the sound of rushing water behind the wall.";
        private const string String07B6 = "You also hear muffled roars.";
        private const string String07D3 = "Loose rocks tumble away, revealing a narrow passageway down.";
        private const string String0810 = "A Gnome Wizard greets you.";
        private const string String082B = "'Thank you for helping my master the Phoenix be reborn.";
        private const string String0863 = "The Phoenix may no longer be disturbed.'";
        private const string String088C = "'I am the Guardian of the Phoenix.  That you have passed my Dragon Guards is proof of your courage.";
        private const string String08F0 = "The way is now clear for you to meet the Phoenix.";
        private const string String0922 = "It is time for the Phoenix to die and so be reborn from its own ashes.";
        private const string String0969 = "Go!  Let the glorious Phoenix die and be renewed!'";
        private const string String099C = "A frightened Halfling Cleric hides in the shadows.";
        private const string String09CF = "'You must do something about these trolls.  They're everywhere.'";
        private const string String0A10 = "An exhausted Dwarf Knight hides in a large barrel.";
        private const string String0A43 = "'Hail!  I welcome your help.  These trolls have been giving me fits.'";
        private const string String0A89 = "A Gnome Wizard suddenly appears.";
        private const string String0AAA = "'Past the CastleGates and past the Elves, you will find a place where the blue light of the sky meets the underworld below.'";
        private const string String0B27 = "An Elf Ranger is delighted at your presense.";
        private const string String0B54 = "'I got clobbered by Andreas, the Earth Elemental!  I wish you luck in your adventurers.'";
        private const string String0BAD = "You feel a sudden increase in your Dexterity.";
        private const string String0BDB = "Nothing happens.";
        private const string String0BEC = "A small band of gypsies has formed camp in an old bazaar stall.";
        private const string String0C2C = "A young gypsy stares at you, gestures you closer, and whispers..";
        private const string String0C6D = "'It is written on the Lava Walls that a Hero will someday reach the end of the rainbow and confront time.'";
        private const string String0CD8 = "He pauses, then says, 'Go now, before more Trolls come!  Go!' ";
        private const string String0D17 = "You sip the cool purple waters of the ElfFoot Fountain";
        private const string String0D4E = "You gain the skill of Rune Reading!";
        private const string String0D72 = "You gain the Channel skill!";
        private const string String0D8E = "You gain the Staff skill!";
        private const string String0DA8 = "You gain the Deep Trance skill!";
        private const string String0DC8 = "Nothing happens.";
        private const string String0DD9 = "The purple waters of the ElfFoot Fountain slip through your fingers before you can wet your lips.";
        private const string String0E3B = "An inscription on the wall reads...";
        private const string String0E5F = "'We, the Dwarves of NottiRock, seek brightly colored metals to forge magnificent treasures.'";
        private const string String0EBC = "Ranger banners decorate the woodwork of Lookout Fountain.";
        private const string String0EF6 = "You gain the skill of Stamina!";
        private const string String0F15 = "You gain the skill of Furtiveness!";
        private const string String0F38 = "You gain the skill of Reading Tracks!";
        private const string String0F5E = "You gain the skill of Archery!";
        private const string String0F7D = "The waters are refreshing, but not enlightening!";
        private const string String0FAE = "A message is etched on wall...";
        private const string String0FCD = "'The runes seem to spell names.  That is the way to Arnakkian.'";
        private const string String100D = "A Human Barbarian belches, then looks up at you.";
        private const string String103E = "'Andreas built a great pit. Two.'";
        private const string String1060 = "Holding up three fingers, he repeats...";
        private const string String1088 = "'Two.  Must need two to cross.'";
        private const string String10A8 = "DayFrost Fountain restores your Health.";
        private const string String10D0 = "NightFrost Fountain renews your Mana.";
        private const string String10F6 = "A Phantasm appears...";
        private const string String110C = "'Dare time?  Yes?  Ah, adventurers should not challenge En-Li-Kil!'";
        private const string String1150 = "The Phantasm drains your life energies.";
        private const string String1178 = "You have died.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => LAVA_01;
        private void LAVA_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // You stumble into the lava river and die.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: // RETURN;
        }

        private override MapEventHandler MapEvent02 => TEMPEST_02;
        private void TEMPEST_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x4F, 0x01, 0x35);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent03 => DUNGEON_03;
        private void DUNGEON_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0425); // This gate leads to the entrance of Arnakkian's Arena.
            L0010: SetMoveMap(party, 0x02, 0x40, 0x02, 0x36);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent04 => HEAVENS_04;
        private void HEAVENS_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0xF6, 0x01, 0x35);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent05 => TXTTEMPS_05;
        private void TXTTEMPS_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String045B); // Of all the winds, the TEMPEST is the most violent and dangerous.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent06 => TXTHEAVN_06;
        private void TXTHEAVN_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String049C); // Enter HEAVEN'S FURY if you must.  It is here Voranti cursed the winds.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent07 => TXTCSTLG_07;
        private void TXTCSTLG_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04E3); // A doorway leads to the town of Castlegate, a village just outside Arnakkian's Castle.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent09 => TXTLOOKO_09;
        private void TXTLOOKO_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0539); // It is rumored that a band of dwarves once lived behind the doors of LookOut.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0C => BDOORCGC_0C;
        private void BDOORCGC_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: compare(ax, 0x0014);
            L0012: if (result.below) goto L0041;
            L0014: ShowMessage(party, String0586); // With a massive effort, you manage to force the door open.
            L0021: Push(01);
            L0025: ax = GetFacing24(party);
            L002C: PushStack(ax);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L003F: goto L004E;
            L0041: ShowMessage(party, String05C0); // The door is stuck and will not open.
            L004E: // RETURN;
        }

        private override MapEventHandler MapEvent10 => RAPID_10;
        private void RAPID_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x02, 0x57, 0x01);
            L0018: ShowMessage(party, String05E5); // A plaque reads..
            L0025: ShowMessage(party, String05F6); // 'Thanks to the gracious generosity of the Mage Council, the survivors of the Arnakkian disaster hereby proclaim a new teleport to the top.'
            L0032: Push(02);
            L0036: ax = GetNextTile20(party);
            L003D: SetMoveMap(party, PopStack(), ax, 0x01, 0x33);
            L0051: // RETURN;
        }

        private override MapEventHandler MapEvent11 => RIVER_11;
        private void RIVER_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0682); // Fighting the raging River of Eternity taps your life energy.
            L0010: ax = GetMaxHits74(party);
            L0017: bx = 0x0004;
            L001A: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L001D: DoDamage90(party, ax);
            L0027: ax = GetCurrentHits70(party);
            L002E: RefreshCompareFlags(ax);
            L0030: if (result.unsigned_greater_than) goto L003F;
            L0032: ShowMessage(party, String06BF); // You have died.
            L003F: // RETURN;
        }

        private override MapEventHandler MapEvent12 => TXTPHNX_12;
        private void TXTPHNX_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState08(party, 0x02, 0x85);
            L0016: if (result.equal) goto L0028;
            L0018: ShowMessage(party, String06CE); // The Phoenix is being reborn and may not be disturbed.
            L0025: goto L00A7;
            L0028: ax = CheckState08(party, 0x02, 0x86);
            L003B: if (result.equal) goto L008D;
            L003D: ShowMessage(party, String0704); // Ahead, bound by the River of Eternity, is the shadow of the Phoenix Firebird. 
            L004A: ShowMessage(party, String0753); // The raging waters of the river look daunting.
            L0057: Push(01);
            L005B: Push(02);
            L005F: ax = GetNextTile20(party);
            L0066: PushStack(ax);
            L0067: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0071: Push(02);
            L0075: ax = GetNextTile20(party);
            L007C: PushStack(ax);
            L007D: Push(01);
            L0081: SetUnblocked30(party);
            L008B: goto L00A7;
            L008D: ShowMessage(party, String0781); // You hear the sound of rushing water behind the wall.
            L009A: ShowMessage(party, String07B6); // You also hear muffled roars.
            L00A7: // RETURN;
        }

        private override MapEventHandler MapEvent13 => DBENCPHO_13;
        private void DBENCPHO_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x0E, 0x01);
            L0015: AddEncounter(party, 0x0E, 0x02);
            L0027: AddEncounter(party, 0x25, 0x03);
            L0039: AddEncounter(party, 0x25, 0x04);
            L004B: AddEncounter(party, 0x26, 0x06);
            L005D: // RETURN;
        }

        private override MapEventHandler MapEvent14 => DBENCA_14;
        private void DBENCA_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x19, 0x01);
            L0015: AddEncounter(party, 0x19, 0x02);
            L0027: AddEncounter(party, 0x19, 0x03);
            L0039: AddEncounter(party, 0x19, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent15 => DBENCB_15;
        private void DBENCB_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x19, 0x01);
            L0015: AddEncounter(party, 0x19, 0x02);
            L0027: AddEncounter(party, 0x1A, 0x03);
            L0039: AddEncounter(party, 0x1A, 0x04);
            L004B: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0x71);
            L006A: // RETURN;
        }

        private override MapEventHandler MapEvent16 => DBENCC_16;
        private void DBENCC_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x19, 0x01);
            L0015: AddEncounter(party, 0x19, 0x02);
            L0027: AddEncounter(party, 0x18, 0x03);
            L0039: AddEncounter(party, 0x18, 0x04);
            L004B: AddEncounter(party, 0x1A, 0x05);
            L005D: AddEncounter(party, 0x1A, 0x06);
            L006F: // RETURN;
        }

        private override MapEventHandler MapEvent17 => DBENCD_17;
        private void DBENCD_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x24, 0x01);
            L0015: AddEncounter(party, 0x24, 0x02);
            L0027: // RETURN;
        }

        private override MapEventHandler MapEvent18 => BAZZENCA_18;
        private void BAZZENCA_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1B, 0x01);
            L0015: AddEncounter(party, 0x1B, 0x02);
            L0027: AddEncounter(party, 0x1C, 0x03);
            L0039: AddEncounter(party, 0x1C, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent19 => BAZZENCB_19;
        private void BAZZENCB_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1C, 0x01);
            L0015: AddEncounter(party, 0x1C, 0x02);
            L0027: AddEncounter(party, 0x1C, 0x03);
            L0039: AddEncounter(party, 0x1C, 0x04);
            L004B: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0x76);
            L006A: // RETURN;
        }

        private override MapEventHandler MapEvent1A => BAZZENCC_1A;
        private void BAZZENCC_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x0F, 0x01);
            L0015: AddEncounter(party, 0x10, 0x02);
            L0027: AddEncounter(party, 0x11, 0x03);
            L0039: AddEncounter(party, 0x1C, 0x04);
            L004B: ax = HasItem50(party, 0xEF);
            L0059: if (result.equal) goto L007C;
            L005B: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L007A: goto L009B;
            L007C: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xEF);
            L009B: // RETURN;
        }

        private override MapEventHandler MapEvent1B => TOELVES_1B;
        private void TOELVES_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07D3); // Loose rocks tumble away, revealing a narrow passageway down.
            L0010: SetMoveMap(party, 0x03, 0x1A, 0x01, 0x37);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent1C => PHOEGURD_1C;
        private void PHOEGURD_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x002D);
            L0010: ShowMessage(party, String0810); // A Gnome Wizard greets you.
            L001D: ax = CheckState08(party, 0x02, 0x85);
            L0030: if (result.equal) goto L004E;
            L0032: ShowMessage(party, String082B); // 'Thank you for helping my master the Phoenix be reborn.
            L003F: ShowMessage(party, String0863); // The Phoenix may no longer be disturbed.'
            L004C: goto L0097;
            L004E: ShowMessage(party, String088C); // 'I am the Guardian of the Phoenix.  That you have passed my Dragon Guards is proof of your courage.
            L005B: ShowMessage(party, String08F0); // The way is now clear for you to meet the Phoenix.
            L0068: ShowMessage(party, String0922); // It is time for the Phoenix to die and so be reborn from its own ashes.
            L0075: ShowMessage(party, String0969); // Go!  Let the glorious Phoenix die and be renewed!'
            L0082: SetState00(party, 0x02, 0x86, 0x01);
            L0097: // RETURN;
        }

        private override MapEventHandler MapEvent1D => TXTBAZZA_1D;
        private void TXTBAZZA_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0029);
            L0010: ShowMessage(party, String099C); // A frightened Halfling Cleric hides in the shadows.
            L001D: ShowMessage(party, String09CF); // 'You must do something about these trolls.  They're everywhere.'
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent1E => TXTBAZZB_1E;
        private void TXTBAZZB_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x001C);
            L0010: ShowMessage(party, String0A10); // An exhausted Dwarf Knight hides in a large barrel.
            L001D: ShowMessage(party, String0A43); // 'Hail!  I welcome your help.  These trolls have been giving me fits.'
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent1F => TXTBAZZC_1F;
        private void TXTBAZZC_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x002D);
            L0010: ShowMessage(party, String0A89); // A Gnome Wizard suddenly appears.
            L001D: ShowMessage(party, String0AAA); // 'Past the CastleGates and past the Elves, you will find a place where the blue light of the sky meets the underworld below.'
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent20 => TXTBAZZD_20;
        private void TXTBAZZD_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x001F);
            L0010: ShowMessage(party, String0B27); // An Elf Ranger is delighted at your presense.
            L001D: ShowMessage(party, String0B54); // 'I got clobbered by Andreas, the Earth Elemental!  I wish you luck in your adventurers.'
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent21 => PHOEREW_21;
        private void PHOEREW_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x5E);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.notequal) goto L0063;
            L0018: SetState00(party, 0x02, 0x5E, 0x01);
            L002D: SetState00(party, 0x02, 0x85, 0x01);
            L0042: ModifyAttributeA8(party, 0x04, 0x00C8);
            L0054: ShowMessage(party, String0BAD); // You feel a sudden increase in your Dexterity.
            L0061: goto L0070;
            L0063: ShowMessage(party, String0BDB); // Nothing happens.
            L0070: // RETURN;
        }

        private override MapEventHandler MapEvent24 => MYSTICS_24;
        private void MYSTICS_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0016);
            L0010: ShowMessage(party, String0BEC); // A small band of gypsies has formed camp in an old bazaar stall.
            L001D: ShowMessage(party, String0C2C); // A young gypsy stares at you, gestures you closer, and whispers..
            L002A: ShowMessage(party, String0C6D); // 'It is written on the Lava Walls that a Hero will someday reach the end of the rainbow and confront time.'
            L0037: ShowMessage(party, String0CD8); // He pauses, then says, 'Go now, before more Trolls come!  Go!' 
            L0044: // RETURN;
        }

        private override MapEventHandler MapEvent25 => FNTNBAZZ_25;
        private void FNTNBAZZ_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x5F);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.equal) goto L001B;
            L0018: goto L011A;
            L001B: SetState00(party, 0x02, 0x5F, 0x01);
            L0030: ShowPortrait(party, 0x0042);
            L003D: ShowMessage(party, String0D17); // You sip the cool purple waters of the ElfFoot Fountain
            L004A: ax = GetSkillLevel5C(party, 0x14);
            L0056: RefreshCompareFlags(ax);
            L0058: if (result.notequal) goto L007B;
            L005A: SetSkillLevel60(party, 0x14, 0x01);
            L006B: ShowMessage(party, String0D4E); // You gain the skill of Rune Reading!
            L0078: goto L0118;
            L007B: ax = GetSkillLevel5C(party, 0x16);
            L0087: RefreshCompareFlags(ax);
            L0089: if (result.notequal) goto L00AB;
            L008B: SetSkillLevel60(party, 0x16, 0x01);
            L009C: ShowMessage(party, String0D72); // You gain the Channel skill!
            L00A9: goto L0118;
            L00AB: ax = GetSkillLevel5C(party, 0x15);
            L00B7: RefreshCompareFlags(ax);
            L00B9: if (result.notequal) goto L00DB;
            L00BB: SetSkillLevel60(party, 0x15, 0x01);
            L00CC: ShowMessage(party, String0D8E); // You gain the Staff skill!
            L00D9: goto L0118;
            L00DB: ax = GetSkillLevel5C(party, 0x17);
            L00E7: RefreshCompareFlags(ax);
            L00E9: if (result.notequal) goto L010B;
            L00EB: SetSkillLevel60(party, 0x17, 0x01);
            L00FC: ShowMessage(party, String0DA8); // You gain the Deep Trance skill!
            L0109: goto L0118;
            L010B: ShowMessage(party, String0DC8); // Nothing happens.
            L0118: goto L0127;
            L011A: ShowMessage(party, String0DD9); // The purple waters of the ElfFoot Fountain slip through your fingers before you can wet your lips.
            L0127: // RETURN;
        }

        private override MapEventHandler MapEvent26 => LOOKENCA_26;
        private void LOOKENCA_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1E, 0x01);
            L0015: AddEncounter(party, 0x1E, 0x02);
            L0027: AddEncounter(party, 0x25, 0x03);
            L0039: AddEncounter(party, 0x25, 0x04);
            L004B: AddEncounter(party, 0x1F, 0x05);
            L005D: AddEncounter(party, 0x1F, 0x06);
            L006F: // RETURN;
        }

        private override MapEventHandler MapEvent2A => TXTLOOKB_2A;
        private void TXTLOOKB_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E3B); // An inscription on the wall reads...
            L0010: ShowRunes(party, String0E5F); // 'We, the Dwarves of NottiRock, seek brightly colored metals to forge magnificent treasures.'
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent2B => FNTNLOOK_2B;
        private void FNTNLOOK_2B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String0EBC); // Ranger banners decorate the woodwork of Lookout Fountain.
            L001D: ax = CheckState04(party, 0x02, 0x60);
            L002E: RefreshCompareFlags(ax);
            L0030: if (result.equal) goto L0035;
            L0032: goto L0118;
            L0035: SetState00(party, 0x02, 0x60, 0x01);
            L004A: ax = GetSkillLevel5C(party, 0x09);
            L0056: RefreshCompareFlags(ax);
            L0058: if (result.notequal) goto L007B;
            L005A: SetSkillLevel60(party, 0x09, 0x02);
            L006B: ShowMessage(party, String0EF6); // You gain the skill of Stamina!
            L0078: goto L0118;
            L007B: ax = GetSkillLevel5C(party, 0x0A);
            L0087: RefreshCompareFlags(ax);
            L0089: if (result.notequal) goto L00AB;
            L008B: SetSkillLevel60(party, 0x0A, 0x02);
            L009C: ShowMessage(party, String0F15); // You gain the skill of Furtiveness!
            L00A9: goto L0118;
            L00AB: ax = GetSkillLevel5C(party, 0x0B);
            L00B7: RefreshCompareFlags(ax);
            L00B9: if (result.notequal) goto L00DB;
            L00BB: SetSkillLevel60(party, 0x0B, 0x02);
            L00CC: ShowMessage(party, String0F38); // You gain the skill of Reading Tracks!
            L00D9: goto L0118;
            L00DB: ax = GetSkillLevel5C(party, 0x08);
            L00E7: RefreshCompareFlags(ax);
            L00E9: if (result.notequal) goto L010B;
            L00EB: SetSkillLevel60(party, 0x08, 0x02);
            L00FC: ShowMessage(party, String0F5E); // You gain the skill of Archery!
            L0109: goto L0118;
            L010B: ShowMessage(party, String0F7D); // The waters are refreshing, but not enlightening!
            L0118: // RETURN;
        }

        private override MapEventHandler MapEvent2C => CSTLENCA_2C;
        private void CSTLENCA_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x17, 0x01);
            L0015: AddEncounter(party, 0x17, 0x02);
            L0027: AddEncounter(party, 0x20, 0x04);
            L0039: AddEncounter(party, 0x17, 0x05);
            L004B: AddEncounter(party, 0x17, 0x06);
            L005D: // RETURN;
        }

        private override MapEventHandler MapEvent2D => CSTLENCB_2D;
        private void CSTLENCB_2D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1D, 0x01);
            L0015: AddEncounter(party, 0x1D, 0x02);
            L0027: AddEncounter(party, 0x1D, 0x04);
            L0039: AddEncounter(party, 0x1D, 0x06);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent2E => CSTLENCC_2E;
        private void CSTLENCC_2E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x18, 0x01);
            L0015: AddEncounter(party, 0x18, 0x02);
            L0027: AddEncounter(party, 0x22, 0x03);
            L0039: AddEncounter(party, 0x22, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent2F => CSTLENCD_2F;
        private void CSTLENCD_2F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1D, 0x01);
            L0015: AddEncounter(party, 0x1D, 0x02);
            L0027: AddEncounter(party, 0x1D, 0x04);
            L0039: AddEncounter(party, 0x18, 0x05);
            L004B: AddEncounter(party, 0x18, 0x06);
            L005D: // RETURN;
        }

        private override MapEventHandler MapEvent30 => CSTLENCE_30;
        private void CSTLENCE_30(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x21, 0x01);
            L0015: AddEncounter(party, 0x21, 0x02);
            L0027: AddEncounter(party, 0x21, 0x04);
            L0039: AddEncounter(party, 0x0A, 0x05);
            L004B: AddEncounter(party, 0x21, 0x06);
            L005D: // RETURN;
        }

        private override MapEventHandler MapEvent35 => TXTCSTLA_35;
        private void TXTCSTLA_35(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0FAE); // A message is etched on wall...
            L0010: ShowMessage(party, String0FCD); // 'The runes seem to spell names.  That is the way to Arnakkian.'
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent36 => TXTCSTLB_36;
        private void TXTCSTLB_36(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0016);
            L0010: ShowMessage(party, String100D); // A Human Barbarian belches, then looks up at you.
            L001D: ShowMessage(party, String103E); // 'Andreas built a great pit. Two.'
            L002A: ShowMessage(party, String1060); // Holding up three fingers, he repeats...
            L0037: ShowMessage(party, String1088); // 'Two.  Must need two to cross.'
            L0044: // RETURN;
        }

        private override MapEventHandler MapEvent37 => FNTNHEAL_37;
        private void FNTNHEAL_37(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetMaxHits74(party);
            L000A: AddHealth94(party, ax);
            L0014: ShowPortrait(party, 0x0042);
            L0021: ShowMessage(party, String10A8); // DayFrost Fountain restores your Health.
            L002E: // RETURN;
        }

        private override MapEventHandler MapEvent38 => FNTNMANA_38;
        private void FNTNMANA_38(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(party, 0x2710);
            L0010: ShowPortrait(party, 0x0042);
            L001D: ShowMessage(party, String10D0); // NightFrost Fountain renews your Mana.
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent3B => TXTCSTLC_3B;
        private void TXTCSTLC_3B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0011);
            L0010: ShowMessage(party, String10F6); // A Phantasm appears...
            L001D: ShowMessage(party, String110C); // 'Dare time?  Yes?  Ah, adventurers should not challenge En-Li-Kil!'
            L002A: ShowMessage(party, String1150); // The Phantasm drains your life energies.
            L0037: ax = GetCurrentHits70(party);
            L003E: bx = 0x0002;
            L0041: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L0044: DoDamage90(party, ax);
            L004E: ax = GetCurrentHits70(party);
            L0055: RefreshCompareFlags(ax);
            L0057: if (result.unsigned_greater_than) goto L0066;
            L0059: ShowMessage(party, String1178); // You have died.
            L0066: // RETURN;
        }

    }
}
