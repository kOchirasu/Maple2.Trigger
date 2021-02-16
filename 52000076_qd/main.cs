namespace Maple2.Trigger._52000076_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
                context.SetActor(arg1: 201, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 202, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 203, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 204, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 205, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 206, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 207, arg2: true, arg3: "Idle_A");
                context.SetInteractObject(arg1: new[] {10000806, 10000806, 10000807, 10000808, 10000809, 10000810, 10000811, 10000812}, arg2: 2);
                context.SetMesh(arg1: new[] {39101, 39102, 39103, 39104, 39105, 39106, 3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815, 3816}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {600, 601, 602, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6201, 6202, 6203, 6204, 6205}, arg2: false);
                context.SetSkill(arg1: new[] {701, 702, 703, 704}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetAgent(arg1: new[] {901, 902, 903, 904}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 11, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001901.xml");
                context.SetOnetimeEffect(id: 12, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001902.xml");
                context.SetOnetimeEffect(id: 13, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001903.xml");
                context.SetOnetimeEffect(id: 14, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001904.xml");
                context.SetOnetimeEffect(id: 15, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001905.xml");
                context.SetOnetimeEffect(id: 16, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001906.xml");
                context.SetOnetimeEffect(id: 17, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001907.xml");
                context.SetOnetimeEffect(id: 18, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001908.xml");
                context.SetOnetimeEffect(id: 19, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001909.xml");
                context.SetOnetimeEffect(id: 20, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001910.xml");
                context.SetUserValue(key: "saveEveIntheDark", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new StateCheckQuestCondition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckQuestCondition : TriggerState {
            internal StateCheckQuestCondition(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {40002688}, arg3: new byte[] {1})) {
                    return new StateDungeonReady(context);
                }

                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {40002688}, arg3: new byte[] {2})) {
                    return new StateQuestOnGoing01(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDungeonReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing01 : TriggerState {
            internal StateQuestOnGoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000076, arg2: 30, arg3: 100);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateQuestOnGoing02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing02 : TriggerState {
            internal StateQuestOnGoing02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 320, arg2: true);
                context.CreateMonster(arg1: new[] {1310, 1410}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateQuestOnGoing03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing03 : TriggerState {
            internal StateQuestOnGoing03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEveTalk30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonReady : TriggerState {
            internal StateDungeonReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new StateDungeonStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "KatvanIntroMovie.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State진행01벽Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행01벽Remove : TriggerState {
            internal State진행01벽Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: false, arg3: "Idle_A");
                context.SetInteractObject(arg1: new[] {10000806}, arg2: 1);
                context.ShowGuideSummary(entityId: 20003492, textId: 20003492);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000806}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003492);
                    context.SetMesh(arg1: new[] {39101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State진행01Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행01Monster : TriggerState {
            internal State진행01Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1101})) {
                    return new State진행01오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행01오브젝트 : TriggerState {
            internal State진행01오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003496, textId: 20003496);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetActor(arg1: 202, arg2: false, arg3: "Idle_A");
                context.SetInteractObject(arg1: new[] {10000807}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000807}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003496);
                    return new State진행02Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행02Monster : TriggerState {
            internal State진행02Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {39102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1004, 1005, 1006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1102})) {
                    return new State진행02오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행02오브젝트 : TriggerState {
            internal State진행02오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003497, textId: 20003497);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetActor(arg1: 203, arg2: false, arg3: "Idle_A");
                context.SetInteractObject(arg1: new[] {10000808}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000808}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003497);
                    return new State진행03Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행03Monster : TriggerState {
            internal State진행03Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {39103}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1007, 1008, 1009}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1103})) {
                    return new State진행04오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행04오브젝트 : TriggerState {
            internal State진행04오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003498, textId: 20003498);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetActor(arg1: 204, arg2: false, arg3: "Idle_A");
                context.SetInteractObject(arg1: new[] {10000809}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000809}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003498);
                    return new State진행04Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행04Monster : TriggerState {
            internal State진행04Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {39104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1010, 1011, 1012}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1104})) {
                    return new State진행05오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행05오브젝트 : TriggerState {
            internal State진행05오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003499, textId: 20003499);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetActor(arg1: 205, arg2: false, arg3: "Idle_A");
                context.SetInteractObject(arg1: new[] {10000810}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000810}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003499);
                    return new State진행05Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행05Monster : TriggerState {
            internal State진행05Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {39105}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1013, 1014, 1015}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1105})) {
                    return new State진행06오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행06오브젝트 : TriggerState {
            internal State진행06오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003500, textId: 20003500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetActor(arg1: 206, arg2: false, arg3: "Idle_A");
                context.SetInteractObject(arg1: new[] {10000811}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000811}, arg2: 0)) {
                    context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "rescue_boroboro");
                    context.HideGuideSummary(entityId: 20003500);
                    return new State진행06Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행06Monster : TriggerState {
            internal State진행06Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {39106}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1016, 1017, 1018, 1019, 1020}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1106})) {
                    return new State레논오브젝트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논오브젝트 : TriggerState {
            internal State레논오브젝트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003495, textId: 20003495);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetActor(arg1: 207, arg2: false, arg3: "Idle_A");
                context.SetInteractObject(arg1: new[] {10000812}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000812}, arg2: 0)) {
                    context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020});
                    context.HideGuideSummary(entityId: 20003495);
                    return new State레논구출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논구출 : TriggerState {
            internal State레논구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetSkip(state: new State레논구출종료(context));
                context.DestroyMonster(arg1: new[] {2001});
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State레논Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script01 : TriggerState {
            internal State레논Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6101}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$02000349_BF__MAIN__3$", arg4: 3);
                context.SetSkip(state: new State레논구출종료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레논Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script02 : TriggerState {
            internal State레논Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6102}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$02000349_BF__MAIN__4$", arg4: 3);
                context.SetSkip(state: new State레논구출종료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State레논구출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논구출종료 : TriggerState {
            internal State레논구출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {301}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State진행07(context);
            }

            public override void OnExit() { }
        }

        private class State진행07 : TriggerState {
            internal State진행07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData2002_AB");
                context.ShowGuideSummary(entityId: 20003501, textId: 20003501, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 127, arg2: new[] {2002})) {
                    return new State진행07Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행07Monster : TriggerState {
            internal State진행07Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1021}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1021})) {
                    return new State진행08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행08 : TriggerState {
            internal State진행08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData2002_C");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 128, arg2: new[] {2002})) {
                    context.SetSkill(arg1: new[] {701}, arg2: true);
                    context.SetEffect(arg1: new[] {6201}, arg2: true);
                    context.DestroyMonster(arg1: new[] {2002});
                    context.CreateMonster(arg1: new[] {2003}, arg2: false);
                    return new State진행09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행09 : TriggerState {
            internal State진행09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData2002_C");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {129})) {
                    return new State진행09Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행09Monster : TriggerState {
            internal State진행09Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData2003_A");
                context.CreateMonster(arg1: new[] {1022}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1022})) {
                    return new State진행10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행10 : TriggerState {
            internal State진행10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData2003_B");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 130, arg2: new[] {2003})) {
                    context.SetSkill(arg1: new[] {702}, arg2: true);
                    context.SetEffect(arg1: new[] {6202}, arg2: true);
                    context.DestroyMonster(arg1: new[] {2003});
                    context.CreateMonster(arg1: new[] {2004}, arg2: false);
                    return new State진행11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행11 : TriggerState {
            internal State진행11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {131})) {
                    return new State진행11Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행11Monster : TriggerState {
            internal State진행11Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2004, arg2: "MS2PatrolData2004_A");
                context.CreateMonster(arg1: new[] {1023}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1023})) {
                    return new State진행12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행12 : TriggerState {
            internal State진행12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2004, arg2: "MS2PatrolData2004_B");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 132, arg2: new[] {2004})) {
                    context.SetSkill(arg1: new[] {703}, arg2: true);
                    context.SetEffect(arg1: new[] {6203}, arg2: true);
                    context.DestroyMonster(arg1: new[] {2004});
                    context.CreateMonster(arg1: new[] {2005}, arg2: false);
                    return new State진행13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행13 : TriggerState {
            internal State진행13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {133})) {
                    return new State진행13Monster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행13Monster : TriggerState {
            internal State진행13Monster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2005, arg2: "MS2PatrolData2005_A");
                context.CreateMonster(arg1: new[] {1024}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1024})) {
                    return new State진행14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행14 : TriggerState {
            internal State진행14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2005, arg2: "MS2PatrolData2005_B");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 134, arg2: new[] {2005})) {
                    context.SetSkill(arg1: new[] {704}, arg2: true);
                    context.SetEffect(arg1: new[] {6204}, arg2: true);
                    context.DestroyMonster(arg1: new[] {2005});
                    context.CreateMonster(arg1: new[] {2007}, arg2: false);
                    return new State진행15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행15 : TriggerState {
            internal State진행15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {135})) {
                    return new State카트반CinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반CinematicDelay : TriggerState {
            internal State카트반CinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1099}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카드반StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반StartCinematic : TriggerState {
            internal State카드반StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "카드반연출종료", arg2: "nextState");
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State카드반Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script01 : TriggerState {
            internal State카드반Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000349_BF__MAIN__5$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State카드반Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script02 : TriggerState {
            internal State카드반Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000349_BF__MAIN__6$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State레논Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Script05 : TriggerState {
            internal State레논Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$02000349_BF__MAIN__7$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State카드반Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script03 : TriggerState {
            internal State카드반Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000349_BF__MAIN__8$", arg4: 6);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State카드반Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script04 : TriggerState {
            internal State카드반Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000349_BF__MAIN__9$", arg4: 8);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State카드반Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script05 : TriggerState {
            internal State카드반Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.CreateMonster(arg1: new[] {1025, 1026}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000349_BF__MAIN__10$", arg4: 7);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State카드반StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반StopCinematic : TriggerState {
            internal State카드반StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.ShowGuideSummary(entityId: 20003502, textId: 20003502, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.DestroyMonster(arg1: new[] {1025, 1026, 1099});
                context.SetAgent(arg1: new[] {901, 902, 903, 904}, arg2: false);
                context.DestroyMonster(arg1: new[] {2007});
                context.CreateMonster(arg1: new[] {2006}, arg2: false);
                context.CameraSelectPath(arg1: new[] {302}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State진행16(context);
            }

            public override void OnExit() { }
        }

        private class State진행16 : TriggerState {
            internal State진행16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 302, arg2: false);
                context.CameraSelect(arg1: 303, arg2: false);
                context.MoveNpc(arg1: 2006, arg2: "MS2PatrolData2006_A");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 136, arg2: new[] {2006})) {
                    return new StateBossBattleStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattleStart01 : TriggerState {
            internal StateBossBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1025, 1026, 1099}, arg2: false);
                context.SetAgent(arg1: new[] {901, 902, 903, 904}, arg2: true);
                context.SetMesh(arg1: new[] {3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815, 3816}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "saveEveIntheDark") == 1) {
                    return new StateBossNpcChange01(context);
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    return new StateBossNpcChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossNpcChange01 : TriggerState {
            internal StateBossNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAgent(arg1: new[] {901, 902, 903, 904}, arg2: false);
                context.SetMesh(arg1: new[] {3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815, 3816}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossNpcChange02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossNpcChange02 : TriggerState {
            internal StateBossNpcChange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1025, 1026, 1099, 2006});
                context.MoveUser(arg1: 52000076, arg2: 20, arg3: 100);
                context.CreateMonster(arg1: new[] {1200, 1300}, arg2: false);
                context.CameraSelect(arg1: 310, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossNpcChange03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossNpcChange03 : TriggerState {
            internal StateBossNpcChange03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 1200, arg2: "Attack_Idle_A", arg3: 15000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossNpcChange04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossNpcChange04 : TriggerState {
            internal StateBossNpcChange04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 311, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEveEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveEnter01 : TriggerState {
            internal StateEveEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1400}, arg2: false);
                context.MoveNpc(arg1: 1400, arg2: "MS2PatrolData_1400");
                context.CameraSelect(arg1: 312, arg2: true);
                context.SetConversation(arg1: 1, arg2: 1400, arg3: "$52000076_QD__MAIN__0$", arg4: 4, arg5: 2);
                context.SetSceneSkip(arg1: "EvilKatvanLeave04", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEveEnter02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveEnter02 : TriggerState {
            internal StateEveEnter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 313, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEveEnter03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveEnter03 : TriggerState {
            internal StateEveEnter03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1300, arg2: "MS2PatrolData_1300");
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
                context.SetConversation(arg1: 1, arg2: 1300, arg3: "$52000076_QD__MAIN__1$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000076_QD__MAIN__2$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEveEnter04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveEnter04 : TriggerState {
            internal StateEveEnter04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 11, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001901.xml");
                context.SetConversation(arg1: 1, arg2: 1200, arg3: "$52000076_QD__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEveTalk01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 11, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001901.xml");
            }
        }

        private class StateEveTalk01 : TriggerState {
            internal StateEveTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 314, arg2: true);
                context.AddCinematicTalk(npcId: 11000523, illustId: "Eve_serious", msg: "$52000076_QD__MAIN__4$", duration: 5000, align: "center");
                context.SetNpcEmotionSequence(arg1: 1400, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEveTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk01Skip : TriggerState {
            internal StateEveTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1400, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEveTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk02 : TriggerState {
            internal StateEveTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000523, illustId: "Eve_serious", msg: "$52000076_QD__MAIN__5$", duration: 5000, align: "center");
                context.SetNpcEmotionSequence(arg1: 1400, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEveTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk02Skip : TriggerState {
            internal StateEveTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1400, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLennonTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk01 : TriggerState {
            internal StateLennonTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000076_QD__MAIN__6$", arg4: 5);
                context.SetNpcEmotionSequence(arg1: 1300, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateLennonTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk01Skip : TriggerState {
            internal StateLennonTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1300, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLennonTurnAround01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTurnAround01 : TriggerState {
            internal StateLennonTurnAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 315, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLennonTurnAround02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTurnAround02 : TriggerState {
            internal StateLennonTurnAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1300, arg2: "MS2PatrolData_1301");
                context.MoveNpc(arg1: 1400, arg2: "MS2PatrolData_1401");
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateLennonTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk02 : TriggerState {
            internal StateLennonTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1300, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000076_QD__MAIN__7$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLennonTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk02Skip : TriggerState {
            internal StateLennonTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1300, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvilKatvanTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanTalk01 : TriggerState {
            internal StateEvilKatvanTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 12, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001902.xml");
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$52000076_QD__MAIN__8$", arg4: 7);
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEvilKatvanTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 12, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001902.xml");
            }
        }

        private class StateEvilKatvanTalk01Skip : TriggerState {
            internal StateEvilKatvanTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateEvilKatvanTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanTalk02 : TriggerState {
            internal StateEvilKatvanTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 13, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001903.xml");
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$52000076_QD__MAIN__9$", arg4: 7);
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEvilKatvanTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 13, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001903.xml");
            }
        }

        private class StateEvilKatvanTalk02Skip : TriggerState {
            internal StateEvilKatvanTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateEvilKatvanTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanTalk03 : TriggerState {
            internal StateEvilKatvanTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 14, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001904.xml");
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$52000076_QD__MAIN__10$", arg4: 6);
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEvilKatvanTalk03Skip(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 14, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001904.xml");
            }
        }

        private class StateEvilKatvanTalk03Skip : TriggerState {
            internal StateEvilKatvanTalk03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEveWalkFront01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveWalkFront01 : TriggerState {
            internal StateEveWalkFront01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Idle_A");
                context.MoveNpc(arg1: 1400, arg2: "MS2PatrolData_1402");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEveTalk10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk10 : TriggerState {
            internal StateEveTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1400, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11000523, illustId: "Eve_serious", msg: "$52000076_QD__MAIN__11$", duration: 5000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEveTalk10Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk10Skip : TriggerState {
            internal StateEveTalk10Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEveTalk11(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionSequence(arg1: 1400, arg2: "Idle_A");
            }
        }

        private class StateEveTalk11 : TriggerState {
            internal StateEveTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1400, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11000523, illustId: "Eve_serious", msg: "$52000076_QD__MAIN__12$", duration: 7000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEveTalk11Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk11Skip : TriggerState {
            internal StateEveTalk11Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEveTalk12(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionSequence(arg1: 1400, arg2: "Idle_A");
            }
        }

        private class StateEveTalk12 : TriggerState {
            internal StateEveTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1400, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11000523, arg3: "$52000076_QD__MAIN__13$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEveTalk12Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk12Skip : TriggerState {
            internal StateEveTalk12Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvilKatvanTalk10(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionSequence(arg1: 1400, arg2: "Idle_A");
            }
        }

        private class StateEvilKatvanTalk10 : TriggerState {
            internal StateEvilKatvanTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 15, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001905.xml");
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$52000076_QD__MAIN__14$", arg4: 6);
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEvilKatvanTalk10Skip(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 15, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001905.xml");
            }
        }

        private class StateEvilKatvanTalk10Skip : TriggerState {
            internal StateEvilKatvanTalk10Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLennonTalk10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk10 : TriggerState {
            internal StateLennonTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Idle_A");
                context.MoveNpc(arg1: 1300, arg2: "MS2PatrolData_1302");
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000076_QD__MAIN__15$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateLennonTalk10Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk10Skip : TriggerState {
            internal StateLennonTalk10Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CameraSelect(arg1: 316, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvilKatvanTalk20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanTalk20 : TriggerState {
            internal StateEvilKatvanTalk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 16, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001906.xml");
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$52000076_QD__MAIN__16$", arg4: 5);
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvilKatvanTalk20Skip(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 16, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001906.xml");
            }
        }

        private class StateEvilKatvanTalk20Skip : TriggerState {
            internal StateEvilKatvanTalk20Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvilKatvanTalk21(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Idle_A");
            }
        }

        private class StateEvilKatvanTalk21 : TriggerState {
            internal StateEvilKatvanTalk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 17, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001907.xml");
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$52000076_QD__MAIN__17$", arg4: 6);
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEvilKatvanTalk21Skip(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 17, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001907.xml");
            }
        }

        private class StateEvilKatvanTalk21Skip : TriggerState {
            internal StateEvilKatvanTalk21Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvilKatvanTalk22(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Idle_A");
            }
        }

        private class StateEvilKatvanTalk22 : TriggerState {
            internal StateEvilKatvanTalk22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 18, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001908.xml");
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$52000076_QD__MAIN__18$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvilKatvanTalk22Skip(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 18, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001908.xml");
            }
        }

        private class StateEvilKatvanTalk22Skip : TriggerState {
            internal StateEvilKatvanTalk22Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CameraSelect(arg1: 317, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLennonTalk20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk20 : TriggerState {
            internal StateLennonTalk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1300, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000076_QD__MAIN__19$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLennonTalk20Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk20Skip : TriggerState {
            internal StateLennonTalk20Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1300, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvilKatvanTalk30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanTalk30 : TriggerState {
            internal StateEvilKatvanTalk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1200, arg2: "MS2PatrolData_1200");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvilKatvanTalk31(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanTalk31 : TriggerState {
            internal StateEvilKatvanTalk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 19, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001909.xml");
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$52000076_QD__MAIN__20$", arg4: 9);
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateEvilKatvanTalk31Skip(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 19, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001909.xml");
            }
        }

        private class StateEvilKatvanTalk31Skip : TriggerState {
            internal StateEvilKatvanTalk31Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Idle_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvilKatvanTalk32(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanTalk32 : TriggerState {
            internal StateEvilKatvanTalk32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001910.xml");
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$52000076_QD__MAIN__21$", arg4: 6);
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Talk_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEvilKatvanTalk32Skip(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 20, enable: false, path: @"BG/Common/Sound/Eff_Sound_52000076_EvilKatvan_DarkRoots_00001910.xml");
            }
        }

        private class StateEvilKatvanTalk32Skip : TriggerState {
            internal StateEvilKatvanTalk32Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1200, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvilKatvanLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanLeave01 : TriggerState {
            internal StateEvilKatvanLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1200, arg2: "MS2PatrolData_1201");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateEvilKatvanLeave02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanLeave02 : TriggerState {
            internal StateEvilKatvanLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1200});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEvilKatvanLeave03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanLeave03 : TriggerState {
            internal StateEvilKatvanLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1300, arg2: "MS2PatrolData_1303");
                context.SetConversation(arg1: 1, arg2: 1300, arg3: "$52000076_QD__MAIN__22$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvilKatvanLeave04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvilKatvanLeave04 : TriggerState {
            internal StateEvilKatvanLeave04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePositionArrange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePositionArrange01 : TriggerState {
            internal StatePositionArrange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1200, 1300, 1400});
                context.MoveUser(arg1: 52000076, arg2: 30, arg3: 100);
                context.CreateMonster(arg1: new[] {1310, 1410}, arg2: false);
                context.CameraSelect(arg1: 320, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePositionArrange02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePositionArrange02 : TriggerState {
            internal StatePositionArrange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateLennonTalk30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk30 : TriggerState {
            internal StateLennonTalk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "EveTalk31Skip", arg2: "nextState");
                context.SetNpcEmotionSequence(arg1: 1310, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000076_QD__MAIN__23$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLennonTalk30Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk30Skip : TriggerState {
            internal StateLennonTalk30Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1310, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLennonTalk31(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk31 : TriggerState {
            internal StateLennonTalk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1310, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000076_QD__MAIN__24$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLennonTalk31Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk31Skip : TriggerState {
            internal StateLennonTalk31Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1310, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEveTalk20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk20 : TriggerState {
            internal StateEveTalk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1410, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11000523, illustId: "Eve_serious", msg: "$52000076_QD__MAIN__25$", duration: 6000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEveTalk20Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk20Skip : TriggerState {
            internal StateEveTalk20Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1410, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEveTalk21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk21 : TriggerState {
            internal StateEveTalk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1410, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11000523, illustId: "Eve_serious", msg: "$52000076_QD__MAIN__26$", duration: 6000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEveTalk21Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk21Skip : TriggerState {
            internal StateEveTalk21Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1410, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLennonTalk40(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk40 : TriggerState {
            internal StateLennonTalk40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1310, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000076_QD__MAIN__27$", arg4: 6);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateLennonTalk40Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLennonTalk40Skip : TriggerState {
            internal StateLennonTalk40Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1310, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEveTalk30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk30 : TriggerState {
            internal StateEveTalk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1410, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11000523, illustId: "Eve_serious", msg: "$52000076_QD__MAIN__28$", duration: 3000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEveTalk30Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk30Skip : TriggerState {
            internal StateEveTalk30Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1410, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.CameraSelect(arg1: 321, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateEveTalk31(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk31 : TriggerState {
            internal StateEveTalk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000523, illustId: "Eve_serious", msg: "$52000076_QD__MAIN__29$", duration: 5000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEveTalk31Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEveTalk31Skip : TriggerState {
            internal StateEveTalk31Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestComplete01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete01 : TriggerState {
            internal StateQuestComplete01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "saveEveIntheDark");
                context.SetEffect(arg1: new[] {6205}, arg2: true);
                context.SetMesh(arg1: new[] {3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: true, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestComplete02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete02 : TriggerState {
            internal StateQuestComplete02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {40002688}, arg3: new byte[] {2})) {
                    return new StateQuestComplete03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete03 : TriggerState {
            internal StateQuestComplete03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1310, arg2: "MS2PatrolData_1304");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGotoTria01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGotoTria01 : TriggerState {
            internal StateGotoTria01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1310, arg3: "$52000076_QD__MAIN__30$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGotoTria02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGotoTria02 : TriggerState {
            internal StateGotoTria02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1410, arg2: "MS2PatrolData_1403");
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGotoTria03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGotoTria03 : TriggerState {
            internal StateGotoTria03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1310, 1410});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGotoTria04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class StateGotoTria04 : TriggerState {
            internal StateGotoTria04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000050, arg2: 1, arg3: 100);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}