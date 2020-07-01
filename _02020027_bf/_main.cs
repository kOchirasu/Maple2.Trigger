using System;

namespace Maple2.Trigger._02020027_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(triggerID: 99990003, key: "Timer", value: 0);
                context.SetUserValue(triggerID: 99990011, key: "SpecialTimer", value: 0);
                context.SetUserValue(triggerID: 99990002, key: "battlesetting", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {1001})) {
                    context.State = new State카메라_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_시작 : TriggerState {
            internal State카메라_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "카메라_종료", arg2: "exit");
                context.MoveUser(arg1: 02020027, arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라_캡션(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_캡션 : TriggerState {
            internal State카메라_캡션(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {5001, 5002}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$02020027_BF__main__2$",
                    desc: "$02020027_BF__main__3$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 4000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State유저연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저연출 : TriggerState {
            internal State유저연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 5003, arg2: true);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02020027_BF__main__4$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라_메이슨설명1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_메이슨설명1 : TriggerState {
            internal State카메라_메이슨설명1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {202});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State유저연출_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저연출_2 : TriggerState {
            internal State유저연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Talk_B", arg3: 18430f);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02020027_BF__main__5$", arg4: 3, arg5: 0);
                context.AddCinematicTalk(npcID: 24120006, illustID: "Mason_normal", msg: "$02020027_BF__main__0$",
                    duration: 4000, align: "left");
                context.RemoveBuff(arg1: 901, arg2: 51200001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_메이슨설명2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_메이슨설명2 : TriggerState {
            internal State카메라_메이슨설명2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 5004, arg2: true);
                context.AddCinematicTalk(npcID: 24120006, illustID: "Mason_normal", msg: "$02020027_BF__main__1$",
                    duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_메이슨설명3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_메이슨설명3 : TriggerState {
            internal State카메라_메이슨설명3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 24120006, illustID: "Mason_normal", msg: "$02020027_BF__main__6$",
                    duration: 4000, align: "left");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_종료 : TriggerState {
            internal State카메라_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.1f);
                context.DestroyMonster(arg1: new int[] {202});
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 1001, arg2: new int[] {201}) && context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투_진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_진행 : TriggerState {
            internal State전투_진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetUserValue(triggerID: 99990002, key: "battlesetting", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "End", value: 1)) {
                    context.State = new State랭크체크대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랭크체크대사 : TriggerState {
            internal State랭크체크대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonFirstUserMissionScore(score: 1500, @operator: "GreaterEqual")) {
                    context.SideNpcTalk(npcID: 24120006, illust: "Mason_normal", duration: 6089,
                        script: "$02020027_BF__main__7$", voice: @"ko/Npc/00002100");
                    context.State = new State던전종료_A랭크이상(context);
                    return;
                }

                if (context.DungeonFirstUserMissionScore(score: 1500, @operator: "Less")) {
                    context.SideNpcTalk(npcID: 24120006, illust: "Mason_closeEye", duration: 5000,
                        script: "$02020027_BF__main__8$", voice: @"ko/Npc/00002099");
                    context.State = new State던전종료_A랭크미만(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크이상 : TriggerState {
            internal State던전종료_A랭크이상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.DungeonClear();
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크미만 : TriggerState {
            internal State던전종료_A랭크미만(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.DungeonFail();
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}