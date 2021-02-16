namespace Maple2.Trigger._02020027_bf {
    public static class _main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, arg2: true);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(triggerId: 99990003, key: "Timer", value: 0);
                context.SetUserValue(triggerId: 99990011, key: "SpecialTimer", value: 0);
                context.SetUserValue(triggerId: 99990002, key: "battlesetting", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    return new StateCamera_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_시작 : TriggerState {
            internal StateCamera_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateCamera_종료(context), arg2: "exit");
                context.MoveUser(arg1: 02020027, arg2: 1);
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
                context.CameraSelectPath(arg1: new[] {5001, 5002}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$02020027_BF__main__2$", desc: "$02020027_BF__main__3$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State유저Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저Cinematic : TriggerState {
            internal State유저Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 5003, arg2: true);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02020027_BF__main__4$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_메이슨설명1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_메이슨설명1 : TriggerState {
            internal StateCamera_메이슨설명1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State유저Cinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저Cinematic_2 : TriggerState {
            internal State유저Cinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Talk_B", arg3: 18430f);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02020027_BF__main__5$", arg4: 3, arg5: 0);
                context.AddCinematicTalk(npcId: 24120006, illustId: "Mason_normal", msg: "$02020027_BF__main__0$", duration: 4000, align: "left");
                context.RemoveBuff(arg1: 901, arg2: 51200001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_메이슨설명2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_메이슨설명2 : TriggerState {
            internal StateCamera_메이슨설명2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 5004, arg2: true);
                context.AddCinematicTalk(npcId: 24120006, illustId: "Mason_normal", msg: "$02020027_BF__main__1$", duration: 4000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_메이슨설명3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_메이슨설명3 : TriggerState {
            internal StateCamera_메이슨설명3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24120006, illustId: "Mason_normal", msg: "$02020027_BF__main__6$", duration: 4000, align: "left");
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
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 1001, arg2: new[] {201}) && context.WaitTick(waitTick: 2000)) {
                    return new State전투_진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_진행 : TriggerState {
            internal State전투_진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, arg2: false);
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
                    context.SideNpcTalk(npcId: 24120006, illust: "Mason_normal", duration: 6089, script: "$02020027_BF__main__7$", voice: @"ko/Npc/00002100");
                    return new State던전종료_A랭크이상(context);
                }

                if (context.GetDungeonFirstUserMissionScore() < 1500) {
                    context.SideNpcTalk(npcId: 24120006, illust: "Mason_closeEye", duration: 5000, script: "$02020027_BF__main__8$", voice: @"ko/Npc/00002099");
                    return new State던전종료_A랭크미만(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크이상 : TriggerState {
            internal State던전종료_A랭크이상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
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
                context.DestroyMonster(arg1: new[] {-1});
                context.DungeonFail();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}