namespace Maple2.Trigger._02020019_bf {
    public static class _02020019_main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.MoveUser(arg1: 02020019, arg2: 1);
                context.SetUserValue(triggerId: 99990002, key: "battlesetting", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Timer", value: 0);
                context.SetUserValue(triggerId: 99990005, key: "SpecialTimer", value: 0);
                context.SetUserValue(triggerId: 99990002, key: "SpecialTimer", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new StateCamera_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_시작 : TriggerState {
            internal StateCamera_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "카메라_종료", arg2: "exit");
                context.MoveUser(arg1: 02020019, arg2: 1);
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera_캡션(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_캡션 : TriggerState {
            internal StateCamera_캡션(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {501, 502}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$02020019_BF__02020019_main__3$", desc: "$02020019_BF__02020019_main__4$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_네이린설명1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_네이린설명1 : TriggerState {
            internal StateCamera_네이린설명1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 503, arg2: true);
                context.AddCinematicTalk(npcId: 24100001, illustId: "Neirin_normal", msg: "$02020019_BF__02020019_main__0$", duration: 4000, align: "left");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 6300f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_네이린설명2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_네이린설명2 : TriggerState {
            internal StateCamera_네이린설명2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24100001, illustId: "Neirin_normal", msg: "$02020019_BF__02020019_main__1$", duration: 4000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_네이린설명3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_네이린설명3 : TriggerState {
            internal StateCamera_네이린설명3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24100001, illustId: "Neirin_normal", msg: "$02020019_BF__02020019_main__5$", duration: 4000, align: "left");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_종료 : TriggerState {
            internal StateCamera_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.1f);
            }

            public override TriggerState Execute() {
                return new State전투_Wait(context);
            }

            public override void OnExit() { }
        }

        private class State전투_Wait : TriggerState {
            internal State전투_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new State전투_진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_진행 : TriggerState {
            internal State전투_진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "battlesetting", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "End") == 1) {
                    return new State랭크체크대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랭크체크대사 : TriggerState {
            internal State랭크체크대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonFirstUserMissionScore() >= 1500) {
                    context.SideNpcTalk(npcId: 24100001, illust: "Neirin_surprise", duration: 5000, script: "$02020019_BF__02020019_main__6$", voice: @"ko/Npc/00002125");
                    return new State던전종료_A랭크이상(context);
                }

                if (context.GetDungeonFirstUserMissionScore() < 1500) {
                    context.SideNpcTalk(npcId: 24100001, illust: "Neirin_smile", duration: 5000, script: "$02020019_BF__02020019_main__7$", voice: @"ko/Npc/00002124");
                    return new State던전종료_A랭크미만(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크이상 : TriggerState {
            internal State던전종료_A랭크이상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크미만 : TriggerState {
            internal State던전종료_A랭크미만(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonFail();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}