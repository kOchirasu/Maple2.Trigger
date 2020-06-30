using System;

namespace Maple2.Trigger._02000290_bf {
    public static class _main_2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "905", arg2: true);
                context.SetAgent(arg1: "906", arg2: true);
                context.SetAgent(arg1: "907", arg2: true);
                context.SetAgent(arg1: "908", arg2: true);
                context.SetLadder(arg1: 531, arg2: false, arg3: false);
                context.SetLadder(arg1: 532, arg2: false, arg3: false);
                context.SetLadder(arg1: 533, arg2: false, arg3: false);
                context.SetLadder(arg1: 534, arg2: false, arg3: false);
                context.SetLadder(arg1: 535, arg2: false, arg3: false);
                context.SetLadder(arg1: 536, arg2: false, arg3: false);
                context.SetMesh(arg1: new int[] {3089}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3108}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 3110, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {3111}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3112, 3113, 3114, 3115, 3116, 3117}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetActor(arg1: 3120, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {3121}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3500, 3501, 3502, 3503, 3504}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.DestroyMonster(arg1: new int[] {1011});
                context.DestroyMonster(arg1: new int[] {1012});
                context.DestroyMonster(arg1: new int[] {1013});
                context.DestroyMonster(arg1: new int[] {1014});
                context.DestroyMonster(arg1: new int[] {1015});
                context.DestroyMonster(arg1: new int[] {1016});
                context.DestroyMonster(arg1: new int[] {1017});
                context.DestroyMonster(arg1: new int[] {1018});
                context.DestroyMonster(arg1: new int[] {1019});
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {6003}, arg2: false);
                context.SetEffect(arg1: new int[] {6004}, arg2: false);
                context.SetEffect(arg1: new int[] {6005}, arg2: false);
                context.SetEffect(arg1: new int[] {6006}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2001})) {
                    context.State = new State사다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성 : TriggerState {
            internal State사다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20002903, textID: 20002903);
                context.SetEffect(arg1: new int[] {5101}, arg2: true);
                context.SetLadder(arg1: 531, arg2: true, arg3: true);
                context.SetLadder(arg1: 532, arg2: true, arg3: true);
                context.SetLadder(arg1: 533, arg2: true, arg3: true);
                context.SetLadder(arg1: 534, arg2: true, arg3: true);
                context.SetLadder(arg1: 535, arg2: true, arg3: true);
                context.SetLadder(arg1: 536, arg2: true, arg3: true);
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 9991, isEnable: true);
                context.EnableSpawnPointPc(spawnPointID: 9992, isEnable: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.HideGuideSummary(entityID: 20002903);
                    context.State = new State트리거09시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거09시작 : TriggerState {
            internal State트리거09시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1011}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1011})) {
                    context.State = new State트리거10시작(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State트리거10시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거10시작 : TriggerState {
            internal State트리거10시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "905", arg2: false);
                context.SetAgent(arg1: "906", arg2: false);
                context.SetMesh(arg1: new int[] {3089}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209},
                    arg2: true, arg3: 0, arg4: 200, arg5: 2f);
                context.CreateMonster(arg1: new int[] {1012}, arg2: false);
                context.CreateMonster(arg1: new int[] {1013}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1012, 1013})) {
                    context.State = new State트리거11시작(context);
                    return;
                }

                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State트리거11시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거11시작 : TriggerState {
            internal State트리거11시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "907", arg2: false);
                context.SetAgent(arg1: "908", arg2: false);
                context.SetMesh(arg1: new int[] {3108}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: true, arg3: 0,
                    arg4: 200, arg5: 2f);
                context.CreateMonster(arg1: new int[] {1014}, arg2: false);
                context.CreateMonster(arg1: new int[] {1015}, arg2: false);
                context.CreateMonster(arg1: new int[] {1016}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1014, 1015, 1016})) {
                    context.State = new State트리거12시작(context);
                    return;
                }

                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State트리거12시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거12시작 : TriggerState {
            internal State트리거12시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3110, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3111}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {1017}, arg2: false);
                context.CreateMonster(arg1: new int[] {1018}, arg2: false);
                context.CreateMonster(arg1: new int[] {1019}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리거12진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거12진행 : TriggerState {
            internal State트리거12진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3110, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3112, 3113, 3114, 3115, 3116, 3117}, arg2: false, arg3: 0, arg4: 200,
                    arg5: 2f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1017, 1018, 1019})) {
                    context.State = new State트리거13시작(context);
                    return;
                }

                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State트리거13시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거13시작 : TriggerState {
            internal State트리거13시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3120, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3121}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State트리거13진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거13진행 : TriggerState {
            internal State트리거13진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3120, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132},
                    arg2: false, arg3: 0, arg4: 200, arg5: 2f);
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 9991, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 9992, isEnable: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2002})) {
                    context.State = new State연출대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출대기 : TriggerState {
            internal State연출대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 801, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetMesh(arg1: new int[] {3500, 3501, 3502, 3503, 3504}, arg2: false, arg3: 0, arg4: 300,
                    arg5: 3f);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {801}, arg2: 1);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State공주구출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State공주구출 : TriggerState {
            internal State공주구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 801, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20002904, textID: 20002904);
                context.SetInteractObject(arg1: new int[] {10000464}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000464}, arg2: 0)) {
                    context.HideGuideSummary(entityID: 20002904);
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, arg2: "$02000290_BF__MAIN_2__2$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State포털생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {910});
                context.CreateMonster(arg1: new int[] {911});
                context.CreateMonster(arg1: new int[] {912});
                context.CreateMonster(arg1: new int[] {913});
                context.CreateMonster(arg1: new int[] {914});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNPC이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동01 : TriggerState {
            internal StateNPC이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 910, arg2: "MS2PatrolData910");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNPC이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동02 : TriggerState {
            internal StateNPC이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 911, arg2: "MS2PatrolData911");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNPC이동03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동03 : TriggerState {
            internal StateNPC이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 912, arg2: "MS2PatrolData912");
                context.MoveNpc(arg1: 914, arg2: "MS2PatrolData914");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNPC이동04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동04 : TriggerState {
            internal StateNPC이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 913, arg2: "MS2PatrolData913");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNPC대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01 : TriggerState {
            internal StateNPC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetConversation(arg1: 1, arg2: 910, arg3: "$02000290_BF__MAIN_2__4$", arg4: 3);
                    context.SetEffect(arg1: new int[] {6003}, arg2: true);
                    context.State = new StateNPC대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02 : TriggerState {
            internal StateNPC대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetConversation(arg1: 1, arg2: 911, arg3: "$02000290_BF__MAIN_2__5$", arg4: 3);
                    context.SetEffect(arg1: new int[] {6004}, arg2: true);
                    context.State = new StateNPC대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사03 : TriggerState {
            internal StateNPC대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetConversation(arg1: 1, arg2: 912, arg3: "$02000290_BF__MAIN_2__6$", arg4: 3);
                    context.SetEffect(arg1: new int[] {6005}, arg2: true);
                    context.State = new StateNPC대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사04 : TriggerState {
            internal StateNPC대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetConversation(arg1: 1, arg2: 913, arg3: "$02000290_BF__MAIN_2__7$", arg4: 3);
                    context.SetEffect(arg1: new int[] {6006}, arg2: true);
                    context.HideGuideSummary(entityID: 20002905);
                    context.State = new State종료대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료대기 : TriggerState {
            internal State종료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 99999, arg2: "trigger", arg3: "ClearYomiprincess");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}