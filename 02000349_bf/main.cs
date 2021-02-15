using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000349_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2001});
                context.SetActor(arg1: 201, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 202, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 203, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 204, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 205, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 206, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 207, arg2: true, arg3: "Idle_A");
                context.SetInteractObject(arg1: new[] {10000806, 10000806, 10000807, 10000808, 10000809, 10000810, 10000811, 10000812, 13000014}, arg2: 2);
                context.SetMesh(arg1: new[] {39101, 39102, 39103, 39104, 39105, 39106, 3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815, 3816}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {600, 601, 602, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6201, 6202, 6203, 6204, 6205}, arg2: false);
                context.SetSkill(arg1: new[] {701, 702, 703, 704}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetAgent(arg1: new[] {901, 902, 903, 904}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
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
                context.SetSkip(arg1: "레논구출종료");
                context.DestroyMonster(arg1: new[] {2001});
                context.CreateMonster(arg1: new[] {2002});
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
                context.SetSkip(arg1: "레논구출종료");
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
                context.SetSkip(arg1: "레논구출종료");
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
                context.CreateMonster(arg1: new[] {1021});
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
                    context.CreateMonster(arg1: new[] {2003});
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
                context.CreateMonster(arg1: new[] {1022});
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
                    context.CreateMonster(arg1: new[] {2004});
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
                context.CreateMonster(arg1: new[] {1023});
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
                    context.CreateMonster(arg1: new[] {2005});
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
                context.CreateMonster(arg1: new[] {1024});
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
                    context.CreateMonster(arg1: new[] {2007});
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
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetSkip(arg1: "카드반연출종료");
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
                context.SetSkip(arg1: "카드반연출종료");
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
                context.SetSkip(arg1: "카드반연출종료");
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
                context.SetSkip(arg1: "카드반연출종료");
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
                context.SetSkip(arg1: "카드반연출종료");
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
                context.SetSkip(arg1: "카드반연출종료");
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
                context.SetSkip(arg1: "카드반연출종료");
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
                context.ShowGuideSummary(entityId: 20003502, textId: 20003502, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.DestroyMonster(arg1: new[] {1025, 1026, 1099});
                context.SetAgent(arg1: new[] {901, 902, 903, 904}, arg2: false);
                context.DestroyMonster(arg1: new[] {2007});
                context.CreateMonster(arg1: new[] {2006});
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
                    return new State진행17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행17 : TriggerState {
            internal State진행17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1025, 1026, 1099}, arg2: false);
                context.SetAgent(arg1: new[] {901, 902, 903, 904}, arg2: true);
                context.SetMesh(arg1: new[] {3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808, 3809, 3810, 3811, 3812, 3813, 3814, 3815, 3816}, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1099})) {
                    return new StateDungeonEndingCinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonEndingCinematicDelay : TriggerState {
            internal StateDungeonEndingCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2006});
                context.CreateMonster(arg1: new[] {2008});
                context.DestroyMonster(arg1: new[] {1025, 1026});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDungeon종료StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeon종료StopCinematic : TriggerState {
            internal StateDungeon종료StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2008, arg3: "$02000349_BF__MAIN__11$", arg4: 3);
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2008, arg3: "$02000349_BF__MAIN__13$", arg4: 4);
                context.MoveNpc(arg1: 2008, arg2: "MS2PatrolData2008_A");
                context.SetEffect(arg1: new[] {6205}, arg2: true);
                context.SetMesh(arg1: new[] {3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.DestroyMonster(arg1: new[] {2008});
                    context.HideGuideSummary(entityId: 20003493);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}