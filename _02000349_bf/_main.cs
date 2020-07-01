using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000349_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

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

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
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

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State진행01벽제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행01벽제거 : TriggerState {
            internal State진행01벽제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: false, arg3: "Idle_A");
                context.SetInteractObject(arg1: new[] {10000806}, arg2: 1);
                context.ShowGuideSummary(entityId: 20003492, textId: 20003492);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000806}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003492);
                    context.SetMesh(arg1: new[] {39101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State진행01몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행01몬스터 : TriggerState {
            internal State진행01몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1101})) {
                    context.State = new State진행01오브젝트(context);
                    return;
                }
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

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000807}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003496);
                    context.State = new State진행02몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행02몬스터 : TriggerState {
            internal State진행02몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {39102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1004, 1005, 1006}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1102})) {
                    context.State = new State진행02오브젝트(context);
                    return;
                }
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

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000808}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003497);
                    context.State = new State진행03몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행03몬스터 : TriggerState {
            internal State진행03몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {39103}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1007, 1008, 1009}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1103})) {
                    context.State = new State진행04오브젝트(context);
                    return;
                }
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

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000809}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003498);
                    context.State = new State진행04몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행04몬스터 : TriggerState {
            internal State진행04몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {39104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1010, 1011, 1012}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1104})) {
                    context.State = new State진행05오브젝트(context);
                    return;
                }
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

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000810}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20003499);
                    context.State = new State진행05몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행05몬스터 : TriggerState {
            internal State진행05몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {39105}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1013, 1014, 1015}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1105})) {
                    context.State = new State진행06오브젝트(context);
                    return;
                }
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

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000811}, arg2: 0)) {
                    context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "rescue_boroboro");
                    context.HideGuideSummary(entityId: 20003500);
                    context.State = new State진행06몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행06몬스터 : TriggerState {
            internal State진행06몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {39106}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1016, 1017, 1018, 1019, 1020}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1106})) {
                    context.State = new State레논오브젝트(context);
                    return;
                }
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

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000812}, arg2: 0)) {
                    context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020});
                    context.HideGuideSummary(entityId: 20003495);
                    context.State = new State레논구출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논구출 : TriggerState {
            internal State레논구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetSkip(arg1: "레논구출종료");
                context.DestroyMonster(arg1: new[] {2001});
                context.CreateMonster(arg1: new[] {2002});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State레논대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논대사01 : TriggerState {
            internal State레논대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6101}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$02000349_BF__MAIN__3$", arg4: 3);
                context.SetSkip(arg1: "레논구출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State레논대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논대사02 : TriggerState {
            internal State레논대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6102}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$02000349_BF__MAIN__4$", arg4: 3);
                context.SetSkip(arg1: "레논구출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State레논구출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논구출종료 : TriggerState {
            internal State레논구출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {301}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State진행07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행07 : TriggerState {
            internal State진행07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData2002_AB");
                context.ShowGuideSummary(entityId: 20003501, textId: 20003501, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 127, arg2: new[] {2002})) {
                    context.State = new State진행07몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행07몬스터 : TriggerState {
            internal State진행07몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1021});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1021})) {
                    context.State = new State진행08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행08 : TriggerState {
            internal State진행08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData2002_C");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 128, arg2: new[] {2002})) {
                    context.SetSkill(arg1: new[] {701}, arg2: true);
                    context.SetEffect(arg1: new[] {6201}, arg2: true);
                    context.DestroyMonster(arg1: new[] {2002});
                    context.CreateMonster(arg1: new[] {2003});
                    context.State = new State진행09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행09 : TriggerState {
            internal State진행09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData2002_C");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {129})) {
                    context.State = new State진행09몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행09몬스터 : TriggerState {
            internal State진행09몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData2003_A");
                context.CreateMonster(arg1: new[] {1022});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1022})) {
                    context.State = new State진행10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행10 : TriggerState {
            internal State진행10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData2003_B");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 130, arg2: new[] {2003})) {
                    context.SetSkill(arg1: new[] {702}, arg2: true);
                    context.SetEffect(arg1: new[] {6202}, arg2: true);
                    context.DestroyMonster(arg1: new[] {2003});
                    context.CreateMonster(arg1: new[] {2004});
                    context.State = new State진행11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행11 : TriggerState {
            internal State진행11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {131})) {
                    context.State = new State진행11몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행11몬스터 : TriggerState {
            internal State진행11몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2004, arg2: "MS2PatrolData2004_A");
                context.CreateMonster(arg1: new[] {1023});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1023})) {
                    context.State = new State진행12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행12 : TriggerState {
            internal State진행12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2004, arg2: "MS2PatrolData2004_B");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 132, arg2: new[] {2004})) {
                    context.SetSkill(arg1: new[] {703}, arg2: true);
                    context.SetEffect(arg1: new[] {6203}, arg2: true);
                    context.DestroyMonster(arg1: new[] {2004});
                    context.CreateMonster(arg1: new[] {2005});
                    context.State = new State진행13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행13 : TriggerState {
            internal State진행13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {133})) {
                    context.State = new State진행13몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행13몬스터 : TriggerState {
            internal State진행13몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2005, arg2: "MS2PatrolData2005_A");
                context.CreateMonster(arg1: new[] {1024});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1024})) {
                    context.State = new State진행14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행14 : TriggerState {
            internal State진행14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2005, arg2: "MS2PatrolData2005_B");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 134, arg2: new[] {2005})) {
                    context.SetSkill(arg1: new[] {704}, arg2: true);
                    context.SetEffect(arg1: new[] {6204}, arg2: true);
                    context.DestroyMonster(arg1: new[] {2005});
                    context.CreateMonster(arg1: new[] {2007});
                    context.State = new State진행15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행15 : TriggerState {
            internal State진행15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {135})) {
                    context.State = new State카트반연출딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카트반연출딜레이 : TriggerState {
            internal State카트반연출딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1099}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카드반연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카드반연출시작 : TriggerState {
            internal State카드반연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetSkip(arg1: "카드반연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카드반대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카드반대사01 : TriggerState {
            internal State카드반대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000349_BF__MAIN__5$", arg4: 3);
                context.SetSkip(arg1: "카드반연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카드반대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카드반대사02 : TriggerState {
            internal State카드반대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000349_BF__MAIN__6$", arg4: 4);
                context.SetSkip(arg1: "카드반연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State레논대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논대사05 : TriggerState {
            internal State레논대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$02000349_BF__MAIN__7$", arg4: 4);
                context.SetSkip(arg1: "카드반연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State카드반대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카드반대사03 : TriggerState {
            internal State카드반대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000349_BF__MAIN__8$", arg4: 6);
                context.SetSkip(arg1: "카드반연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State카드반대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카드반대사04 : TriggerState {
            internal State카드반대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000349_BF__MAIN__9$", arg4: 8);
                context.SetSkip(arg1: "카드반연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State카드반대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카드반대사05 : TriggerState {
            internal State카드반대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
                context.CreateMonster(arg1: new[] {1025, 1026}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000349_BF__MAIN__10$", arg4: 7);
                context.SetSkip(arg1: "카드반연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State카드반연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카드반연출종료 : TriggerState {
            internal State카드반연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003502, textId: 20003502, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.DestroyMonster(arg1: new[] {1025, 1026, 1099});
                context.SetAgent(arg1: new[] {901, 902, 903, 904}, arg2: false);
                context.DestroyMonster(arg1: new[] {2007});
                context.CreateMonster(arg1: new[] {2006});
                context.CameraSelectPath(arg1: new[] {302}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State진행16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행16 : TriggerState {
            internal State진행16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 302, arg2: false);
                context.CameraSelect(arg1: 303, arg2: false);
                context.MoveNpc(arg1: 2006, arg2: "MS2PatrolData2006_A");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 136, arg2: new[] {2006})) {
                    context.State = new State진행17(context);
                    return;
                }
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

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1099})) {
                    context.State = new State던전종료연출딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료연출딜레이 : TriggerState {
            internal State던전종료연출딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2006});
                context.CreateMonster(arg1: new[] {2008});
                context.DestroyMonster(arg1: new[] {1025, 1026});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State던전종료연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료연출종료 : TriggerState {
            internal State던전종료연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2008, arg3: "$02000349_BF__MAIN__11$", arg4: 3);
                context.DungeonClear();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State포털생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2008, arg3: "$02000349_BF__MAIN__13$", arg4: 4);
                context.MoveNpc(arg1: 2008, arg2: "MS2PatrolData2008_A");
                context.SetEffect(arg1: new[] {6205}, arg2: true);
                context.SetMesh(arg1: new[] {3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.DestroyMonster(arg1: new[] {2008});
                    context.HideGuideSummary(entityId: 20003493);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}