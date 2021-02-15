namespace Maple2.Trigger._02020021_bf {
    public static class _main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008}, arg2: true);
                context.SetUserValue(triggerId: 99990002, key: "battlesetting", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Timer", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "SpecialTimer", value: 0);
                context.SetUserValue(triggerId: 99990002, key: "SpecialTimer", value: 0);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
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
                context.SetSceneSkip(arg1: "Camera_종료", arg2: "exit");
                context.CreateMonster(arg1: new[] {202}, arg2: false);
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
                context.ShowCaption(type: "VerticalCaption", title: "$02020021_BF__main__3$", desc: "$02020021_BF__main__4$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_샤텐Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_샤텐Script1 : TriggerState {
            internal StateCamera_샤텐Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {503, 504}, arg2: false);
                context.AddCinematicTalk(npcId: 23200085, illustId: "Schatten_normal", msg: "$02020021_BF__main__0$", duration: 4000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_샤텐Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_샤텐Script2 : TriggerState {
            internal StateCamera_샤텐Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 23200085, illustId: "Schatten_normal", msg: "$02020021_BF__main__1$", duration: 4000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_샤텐Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_샤텐Script3 : TriggerState {
            internal StateCamera_샤텐Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {505, 506}, arg2: false);
                context.AddCinematicTalk(npcId: 23200085, illustId: "Schatten_normal", msg: "$02020021_BF__main__2$", duration: 4000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_샤텐Script4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_샤텐Script4 : TriggerState {
            internal StateCamera_샤텐Script4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {507, 508}, arg2: false);
                context.AddCinematicTalk(npcId: 23200085, illustId: "Schatten_normal", msg: "$02020021_BF__main__5$", duration: 4000, align: "left");
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
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.1f);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 901, arg2: new[] {201}) && context.WaitTick(waitTick: 2000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008}, arg2: false);
                context.SetAiExtraData(key: "Start", value: 1);
                context.SideNpcTalk(npcId: 23200085, illust: "Schatten_smile", duration: 5000, script: "$02020021_BF__main__6$", voice: @"ko/Npc/00002248");
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
                    context.SideNpcTalk(npcId: 23200085, illust: "Schatten_smile", duration: 5000, script: "$02020021_BF__main__7$", voice: @"ko/Npc/00002082");
                    return new State던전종료_A랭크이상(context);
                }

                if (context.GetDungeonFirstUserMissionScore() < 1500) {
                    context.SideNpcTalk(npcId: 23200085, illust: "Schatten_serious", duration: 5000, script: "$02020021_BF__main__8$", voice: @"ko/Npc/00002081");
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