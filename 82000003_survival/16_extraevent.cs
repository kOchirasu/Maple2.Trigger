using Maple2.Trigger.Enum;

namespace Maple2.Trigger._82000003_survival {
    public static class _16_extraevent {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9000}, skillId: 70001101, level: 1, arg4: false, arg5: false);
                context.SetGravity(gravity: 0f);
                context.RemoveBuff(boxId: 9000, skillId: 71000075);
                context.RemoveBuff(boxId: 9000, skillId: 71000052);
                context.RemoveBuff(boxId: 9000, skillId: 71000076);
                context.SetUserValue(key: "ExtraEventCheck", value: 0);
                context.SetUserValue(key: "ExtraEventOff", value: 0);
                context.SetUserValue(key: "ExtraEventTestOn", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExtraEventTestOn") == 1) {
                    return new StateExtraEventOn(context);
                }

                if (context.GetUserValue(key: "ExtraEventCheck") == 1) {
                    return new StateExtraEventOccurrenceProbability(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExtraEventOccurrenceProbability : TriggerState {
            internal StateExtraEventOccurrenceProbability(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 60f)) {
                    return new StateExtraEventOff(context);
                }

                if (context.RandomCondition(rate: 40f)) {
                    return new StateExtraEventOn(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExtraEventOff : TriggerState {
            internal StateExtraEventOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExtraEventOn : TriggerState {
            internal StateExtraEventOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MokumEventOn");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRelicLeft05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRelicLeft05 : TriggerState {
            internal StateRelicLeft05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 11, key: "RelicMobSpawn", value: 1);
                context.SetUserValue(triggerId: 12, key: "RelicMobSpawn", value: 1);
                context.SetUserValue(triggerId: 13, key: "RelicMobSpawn", value: 1);
                context.SetUserValue(triggerId: 14, key: "RelicMobSpawn", value: 1);
                context.SetUserValue(triggerId: 15, key: "RelicMobSpawn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft04_NoRed(context);
                }

                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft04_NoSkyblue(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft04_NoGreen(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft04_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft04_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200002, textId: 28200002, duration: 4000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__0$");
            }
        }

        private class StateRelicLeft04_NoRed : TriggerState {
            internal StateRelicLeft04_NoRed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MokumKill_01");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft03_NoRed_NoSkyblue(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft03_NoRed_NoGreen(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft03_NoRed_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft03_NoRed_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200003, textId: 28200003, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__1$");
            }
        }

        private class StateRelicLeft04_NoSkyblue : TriggerState {
            internal StateRelicLeft04_NoSkyblue(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft03_NoRed_NoSkyblue(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft03_NoSkyblue_NoGreen(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft03_NoSkyblue_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft03_NoSkyblue_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200003, textId: 28200003, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__1$");
            }
        }

        private class StateRelicLeft04_NoGreen : TriggerState {
            internal StateRelicLeft04_NoGreen(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft03_NoRed_NoGreen(context);
                }

                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft03_NoSkyblue_NoGreen(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft03_NoGreen_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft03_NoGreen_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200003, textId: 28200003, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__1$");
            }
        }

        private class StateRelicLeft04_NoYellow : TriggerState {
            internal StateRelicLeft04_NoYellow(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft03_NoRed_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft03_NoSkyblue_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft03_NoGreen_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft03_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200003, textId: 28200003, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__1$");
            }
        }

        private class StateRelicLeft04_NoGrey : TriggerState {
            internal StateRelicLeft04_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft03_NoRed_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft03_NoSkyblue_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft03_NoGreen_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft03_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200003, textId: 28200003, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__1$");
            }
        }

        private class StateRelicLeft03_NoRed_NoSkyblue : TriggerState {
            internal StateRelicLeft03_NoRed_NoSkyblue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MokumKill_02");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoSkyblue_NoGreen(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoSkyblue_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoSkyblue_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200004, textId: 28200004, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__2$");
            }
        }

        private class StateRelicLeft03_NoRed_NoGreen : TriggerState {
            internal StateRelicLeft03_NoRed_NoGreen(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoSkyblue_NoGreen(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoGreen_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoGreen_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200004, textId: 28200004, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__2$");
            }
        }

        private class StateRelicLeft03_NoRed_NoYellow : TriggerState {
            internal StateRelicLeft03_NoRed_NoYellow(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoSkyblue_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoGreen_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200004, textId: 28200004, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__2$");
            }
        }

        private class StateRelicLeft03_NoRed_NoGrey : TriggerState {
            internal StateRelicLeft03_NoRed_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoSkyblue_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoGreen_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200004, textId: 28200004, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__2$");
            }
        }

        private class StateRelicLeft03_NoSkyblue_NoGreen : TriggerState {
            internal StateRelicLeft03_NoSkyblue_NoGreen(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoSkyblue_NoGreen(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft02_NoSkyblue_NoGreen_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft02_NoSkyblue_NoGreen_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200004, textId: 28200004, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__2$");
            }
        }

        private class StateRelicLeft03_NoSkyblue_NoYellow : TriggerState {
            internal StateRelicLeft03_NoSkyblue_NoYellow(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoSkyblue_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft02_NoSkyblue_NoGreen_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft02_NoSkyblue_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200004, textId: 28200004, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__2$");
            }
        }

        private class StateRelicLeft03_NoSkyblue_NoGrey : TriggerState {
            internal StateRelicLeft03_NoSkyblue_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoSkyblue_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft02_NoSkyblue_NoGreen_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft02_NoSkyblue_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200004, textId: 28200004, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__2$");
            }
        }

        private class StateRelicLeft03_NoGreen_NoYellow : TriggerState {
            internal StateRelicLeft03_NoGreen_NoYellow(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoGreen_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft02_NoSkyblue_NoGreen_NoYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft02_NoGreen_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200004, textId: 28200004, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__2$");
            }
        }

        private class StateRelicLeft03_NoGreen_NoGrey : TriggerState {
            internal StateRelicLeft03_NoGreen_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoGreen_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft02_NoSkyblue_NoGreen_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft02_NoGreen_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200004, textId: 28200004, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__2$");
            }
        }

        private class StateRelicLeft03_NoYellow_NoGrey : TriggerState {
            internal StateRelicLeft03_NoYellow_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft02_NoRed_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft02_NoSkyblue_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft02_NoGreen_NoYellow_NoGrey(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200004, textId: 28200004, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__2$");
            }
        }

        private class StateRelicLeft02_NoRed_NoSkyblue_NoGreen : TriggerState {
            internal StateRelicLeft02_NoRed_NoSkyblue_NoGreen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MokumKill_03");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft01_OnlyGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft01_OnlyYellow(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200005, textId: 28200005, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__3$");
            }
        }

        private class StateRelicLeft02_NoRed_NoSkyblue_NoYellow : TriggerState {
            internal StateRelicLeft02_NoRed_NoSkyblue_NoYellow(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft01_OnlyGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft01_OnlyGreen(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200005, textId: 28200005, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__3$");
            }
        }

        private class StateRelicLeft02_NoRed_NoSkyblue_NoGrey : TriggerState {
            internal StateRelicLeft02_NoRed_NoSkyblue_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft01_OnlyYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft01_OnlyGreen(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200005, textId: 28200005, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__3$");
            }
        }

        private class StateRelicLeft02_NoRed_NoGreen_NoYellow : TriggerState {
            internal StateRelicLeft02_NoRed_NoGreen_NoYellow(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft01_OnlyGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft01_OnlySkyblue(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200005, textId: 28200005, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__3$");
            }
        }

        private class StateRelicLeft02_NoRed_NoGreen_NoGrey : TriggerState {
            internal StateRelicLeft02_NoRed_NoGreen_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft01_OnlyYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft01_OnlySkyblue(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200005, textId: 28200005, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__3$");
            }
        }

        private class StateRelicLeft02_NoRed_NoYellow_NoGrey : TriggerState {
            internal StateRelicLeft02_NoRed_NoYellow_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft01_OnlyGreen(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft01_OnlySkyblue(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200005, textId: 28200005, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__3$");
            }
        }

        private class StateRelicLeft02_NoSkyblue_NoGreen_NoYellow : TriggerState {
            internal StateRelicLeft02_NoSkyblue_NoGreen_NoYellow(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft01_OnlyGrey(context);
                }

                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateRelicLeft01_OnlyRed(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200005, textId: 28200005, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__3$");
            }
        }

        private class StateRelicLeft02_NoSkyblue_NoGreen_NoGrey : TriggerState {
            internal StateRelicLeft02_NoSkyblue_NoGreen_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft01_OnlyYellow(context);
                }

                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateRelicLeft01_OnlyRed(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200005, textId: 28200005, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__3$");
            }
        }

        private class StateRelicLeft02_NoSkyblue_NoYellow_NoGrey : TriggerState {
            internal StateRelicLeft02_NoSkyblue_NoYellow_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft01_OnlyGreen(context);
                }

                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateRelicLeft01_OnlyRed(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200005, textId: 28200005, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__3$");
            }
        }

        private class StateRelicLeft02_NoGreen_NoYellow_NoGrey : TriggerState {
            internal StateRelicLeft02_NoGreen_NoYellow_NoGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateRelicLeft01_OnlySkyblue(context);
                }

                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateRelicLeft01_OnlyRed(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200005, textId: 28200005, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__3$");
            }
        }

        private class StateRelicLeft01_OnlyRed : TriggerState {
            internal StateRelicLeft01_OnlyRed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MokumKill_04");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRedDie") == 1) {
                    return new StateExtraEventRandomDelay01(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200006, textId: 28200006, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__4$");
            }
        }

        private class StateRelicLeft01_OnlySkyblue : TriggerState {
            internal StateRelicLeft01_OnlySkyblue(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobSkyblueDie") == 1) {
                    return new StateExtraEventRandomDelay01(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200006, textId: 28200006, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__4$");
            }
        }

        private class StateRelicLeft01_OnlyGreen : TriggerState {
            internal StateRelicLeft01_OnlyGreen(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobGreenDie") == 1) {
                    return new StateExtraEventRandomDelay01(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200006, textId: 28200006, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__4$");
            }
        }

        private class StateRelicLeft01_OnlyYellow : TriggerState {
            internal StateRelicLeft01_OnlyYellow(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobYellowDie") == 1) {
                    return new StateExtraEventRandomDelay01(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200006, textId: 28200006, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__4$");
            }
        }

        private class StateRelicLeft01_OnlyGrey : TriggerState {
            internal StateRelicLeft01_OnlyGrey(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobGreyDie") == 1) {
                    return new StateExtraEventRandomDelay01(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Die_01");
                context.ShowGuideSummary(entityId: 28200006, textId: 28200006, duration: 3000);
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 5000, script: "$82000002_survival__16_ExtraEvent__4$");
            }
        }

        private class StateExtraEventRandomDelay01 : TriggerState {
            internal StateExtraEventRandomDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateExtraEventRandomDelay02(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExtraEventRandomDelay02 : TriggerState {
            internal StateExtraEventRandomDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Message_01");
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 8000, script: "$82000002_survival__16_ExtraEvent__5$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateExtraEventRandomDelay03(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExtraEventRandomDelay03 : TriggerState {
            internal StateExtraEventRandomDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Mokum_Popup_UI_01");
                context.ShowGuideSummary(entityId: 28200007, textId: 28200007, duration: 4000);
                context.WriteLog(logName: "Survival", @event: "MokumEventStart");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateExtraEventRandom(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExtraEventRandom : TriggerState {
            internal StateExtraEventRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20f)) {
                    return new StateExtraEvent01_Fast(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new StateExtraEvent02_MapHack(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new StateExtraEvent03_RobotSpawn(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new StateExtraEvent04_SkillCoolDownTimeReduce(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new StateExtraEvent05_NoMoreFarming(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExtraEvent01_Fast : TriggerState {
            internal StateExtraEvent01_Fast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MokumEvent_01");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Completion_01");
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 8000, script: "$82000002_survival__16_ExtraEvent__6$");
                context.AddBuff(boxIds: new []{9000}, skillId: 71000075, level: 1, arg4: false, arg5: false);
                context.SetGravity(gravity: 30f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExtraEvent02_MapHack : TriggerState {
            internal StateExtraEvent02_MapHack(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MokumEvent_02");
                context.RemoveBuff(boxId: 9000, skillId: 71000052);
                context.PlaySystemSoundInBox(sound: "System_Mokum_Completion_01");
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 8000, script: "$82000002_survival__16_ExtraEvent__7$");
                context.AddBuff(boxIds: new []{9000}, skillId: 71000052, level: 2, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExtraEvent03_RobotSpawn : TriggerState {
            internal StateExtraEvent03_RobotSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MokumEvent_03");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Completion_01");
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 8000, script: "$82000002_survival__16_ExtraEvent__8$");
                context.SetUserValue(triggerId: 10, key: "BattleRidingOnCount", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 10, key: "BattleRidingOff", value: 1);
            }
        }

        private class StateExtraEvent04_SkillCoolDownTimeReduce : TriggerState {
            internal StateExtraEvent04_SkillCoolDownTimeReduce(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MokumEvent_04");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Completion_01");
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 8000, script: "$82000002_survival__16_ExtraEvent__9$");
                context.AddBuff(boxIds: new []{9000}, skillId: 71000076, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExtraEvent05_NoMoreFarming : TriggerState {
            internal StateExtraEvent05_NoMoreFarming(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WriteLog(logName: "Survival", @event: "MokumEvent_05");
                context.PlaySystemSoundInBox(sound: "System_Mokum_Completion_01");
                context.SideNpcTalk(npcId: 21001019, type: SideNpcTalkType.TalkBottom, illust: "MushroomRichPorter_normal", duration: 8000, script: "$82000002_survival__16_ExtraEvent__10$");
                context.StartCombineSpawn(groupId: new []{355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477}, isStart: false);
                context.StartCombineSpawn(groupId: new []{10000342, 10000343, 10000344, 10000345, 10000346, 10000347, 10000348, 10000349, 10000350, 10000351, 10000352, 10000353, 10000354, 10000355, 10000356, 10000357, 10000358, 10000359, 10000360, 10000361, 10000362, 10000363, 10000364, 10000365, 10000366, 10000367, 10000368, 10000369, 10000370, 10000371, 10000372, 10000373, 10000374, 10000375, 10000376, 10000377, 10000378, 10000379, 10000380, 10000381}, isStart: false);
                context.StartCombineSpawn(groupId: new []{319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354}, isStart: false);
                context.StartCombineSpawn(groupId: new []{10000382, 10000383, 10000384, 10000385, 10000386, 10000387, 10000388, 10000389, 10000390, 10000391, 10000392, 10000393, 10000394, 10000395, 10000396, 10000397, 10000398, 10000399, 10000400, 10000401, 10000402, 10000403, 10000404, 10000405, 10000406, 10000407, 10000408, 10000409, 10000410, 10000411, 10000412, 10000413, 10000414, 10000415, 10000416, 10000417, 10000418, 10000419, 10000420, 10000421, 10000422, 10000423, 10000424, 10000425, 10000426, 10000427, 10000428, 10000429, 10000430, 10000431, 10000432, 10000433, 10000434, 10000435, 10000436, 10000437, 10000438, 10000439, 10000440, 10000441, 10000442, 10000443, 10000444, 10000445, 10000446, 10000447, 10000448, 10000449, 10000450, 10000451, 10000452, 10000453, 10000454, 10000455, 10000456, 10000457, 10000458, 10000459, 10000460, 10000461, 10000462, 10000463, 10000464, 10000465, 10000466, 10000467, 10000468, 10000469, 10000470, 10000471, 10000472, 10000473, 10000474, 10000475, 10000476, 10000477, 10000478, 10000479, 10000480, 10000481, 10000482, 10000483, 10000484, 10000485, 10000486, 10000487, 10000488, 10000489, 10000490, 10000491, 10000492, 10000493, 10000494, 10000495, 10000496, 10000497, 10000498, 10000499, 10000500, 10000501, 10000502, 10000503, 10000504, 10000505, 10000506}, isStart: false);
                context.SetUserValue(triggerId: 5, key: "RareBoxOff", value: 1);
                context.SetUserValue(triggerId: 8, key: "RareMobOff", value: 1);
                context.SetUserValue(triggerId: 9, key: "NormaBoxOff", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 11, key: "RelicMobRemove", value: 1);
                context.SetUserValue(triggerId: 12, key: "RelicMobRemove", value: 1);
                context.SetUserValue(triggerId: 13, key: "RelicMobRemove", value: 1);
                context.SetUserValue(triggerId: 14, key: "RelicMobRemove", value: 1);
                context.SetUserValue(triggerId: 15, key: "RelicMobRemove", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
