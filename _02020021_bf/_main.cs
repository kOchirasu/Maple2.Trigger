using System;

namespace Maple2.Trigger._02020021_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9001", arg2: true);
                context.SetAgent(arg1: "9002", arg2: true);
                context.SetAgent(arg1: "9003", arg2: true);
                context.SetAgent(arg1: "9004", arg2: true);
                context.SetAgent(arg1: "9005", arg2: true);
                context.SetAgent(arg1: "9006", arg2: true);
                context.SetAgent(arg1: "9007", arg2: true);
                context.SetAgent(arg1: "9008", arg2: true);
                context.SetUserValue(triggerID: 99990002, key: "battlesetting", value: 0);
                context.SetUserValue(triggerID: 99990003, key: "Timer", value: 0);
                context.SetUserValue(triggerID: 99990004, key: "SpecialTimer", value: 0);
                context.SetUserValue(triggerID: 99990002, key: "SpecialTimer", value: 0);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {901})) {
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
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
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
                context.CameraSelectPath(arg1: new int[] {501, 502}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$02020021_BF__main__3$",
                    desc: "$02020021_BF__main__4$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 4000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_샤텐대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_샤텐대사1 : TriggerState {
            internal State카메라_샤텐대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {503, 504}, arg2: false);
                context.AddCinematicTalk(npcID: 23200085, illustID: "Schatten_normal", msg: "$02020021_BF__main__0$",
                    duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_샤텐대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_샤텐대사2 : TriggerState {
            internal State카메라_샤텐대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 23200085, illustID: "Schatten_normal", msg: "$02020021_BF__main__1$",
                    duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_샤텐대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_샤텐대사3 : TriggerState {
            internal State카메라_샤텐대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {505, 506}, arg2: false);
                context.AddCinematicTalk(npcID: 23200085, illustID: "Schatten_normal", msg: "$02020021_BF__main__2$",
                    duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_샤텐대사4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_샤텐대사4 : TriggerState {
            internal State카메라_샤텐대사4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {507, 508}, arg2: false);
                context.AddCinematicTalk(npcID: 23200085, illustID: "Schatten_normal", msg: "$02020021_BF__main__5$",
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
                context.DestroyMonster(arg1: new int[] {202});
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.1f);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 901, arg2: new int[] {201}) && context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9001", arg2: false);
                context.SetAgent(arg1: "9002", arg2: false);
                context.SetAgent(arg1: "9003", arg2: false);
                context.SetAgent(arg1: "9004", arg2: false);
                context.SetAgent(arg1: "9005", arg2: false);
                context.SetAgent(arg1: "9006", arg2: false);
                context.SetAgent(arg1: "9007", arg2: false);
                context.SetAgent(arg1: "9008", arg2: false);
                context.SetAiExtraData(key: "Start", value: 1);
                context.SideNpcTalk(npcID: 23200085, illust: "Schatten_smile", duration: 5000,
                    script: "$02020021_BF__main__6$", voice: @"ko/Npc/00002248");
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
                    context.SideNpcTalk(npcID: 23200085, illust: "Schatten_smile", duration: 5000,
                        script: "$02020021_BF__main__7$", voice: @"ko/Npc/00002082");
                    context.State = new State던전종료_A랭크이상(context);
                    return;
                }

                if (context.DungeonFirstUserMissionScore(score: 1500, @operator: "Less")) {
                    context.SideNpcTalk(npcID: 23200085, illust: "Schatten_serious", duration: 5000,
                        script: "$02020021_BF__main__8$", voice: @"ko/Npc/00002081");
                    context.State = new State던전종료_A랭크미만(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크이상 : TriggerState {
            internal State던전종료_A랭크이상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크미만 : TriggerState {
            internal State던전종료_A랭크미만(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonFail();
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}