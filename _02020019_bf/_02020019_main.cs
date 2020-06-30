using System;

namespace Maple2.Trigger._02020019_bf {
    public static class _02020019_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.MoveUser(arg1: 02020019, arg2: 1);
                context.SetUserValue(triggerID: 99990002, key: "battlesetting", value: 0);
                context.SetUserValue(triggerID: 99990004, key: "Timer", value: 0);
                context.SetUserValue(triggerID: 99990005, key: "SpecialTimer", value: 0);
                context.SetUserValue(triggerID: 99990002, key: "SpecialTimer", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "901")) {
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
                context.MoveUser(arg1: 02020019, arg2: 1);
                context.CreateMonster(arg1: new int[] {101, 102, 103}, arg2: false);
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
                context.CameraSelectPath(arg1: new int[] {501, 502}, arg2: 0);
                context.ShowCaption(type: "VerticalCaption", title: "$02020019_BF__02020019_main__3$",
                    desc: "$02020019_BF__02020019_main__4$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 4000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_네이린설명1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_네이린설명1 : TriggerState {
            internal State카메라_네이린설명1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 503, arg2: true);
                context.AddCinematicTalk(npcID: 24100001, illustID: "Neirin_normal",
                    msg: "$02020019_BF__02020019_main__0$", duration: 4000, align: "left");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 6300f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_네이린설명2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_네이린설명2 : TriggerState {
            internal State카메라_네이린설명2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 24100001, illustID: "Neirin_normal",
                    msg: "$02020019_BF__02020019_main__1$", duration: 4000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라_네이린설명3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_네이린설명3 : TriggerState {
            internal State카메라_네이린설명3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 24100001, illustID: "Neirin_normal",
                    msg: "$02020019_BF__02020019_main__5$", duration: 4000, align: "left");
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
            }

            public override void Execute() {
                if (true) {
                    context.State = new State전투_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_대기 : TriggerState {
            internal State전투_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "901")) {
                    context.State = new State전투_진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_진행 : TriggerState {
            internal State전투_진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
                    context.SideNpcTalk(npcID: 24100001, illust: "Neirin_surprise", duration: 5000,
                        script: "$02020019_BF__02020019_main__6$", voice: @"ko/Npc/00002125");
                    context.State = new State던전종료_A랭크이상(context);
                    return;
                }

                if (context.DungeonFirstUserMissionScore(score: 1500, @operator: "Less")) {
                    context.SideNpcTalk(npcID: 24100001, illust: "Neirin_smile", duration: 5000,
                        script: "$02020019_BF__02020019_main__7$", voice: @"ko/Npc/00002124");
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