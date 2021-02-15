namespace Maple2.Trigger._02020025_bf {
    public static class _main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008}, arg2: true);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(triggerId: 99990004, key: "Timer", value: 0);
                context.SetUserValue(triggerId: 99990006, key: "SpecialTimer", value: 0);
                context.SetUserValue(triggerId: 99990002, key: "battlesetting", value: 0);
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
                context.MoveUser(arg1: 02020025, arg2: 1);
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
                context.CameraSelectPath(arg1: new[] {5001, 5002}, arg2: true);
                context.ShowCaption(type: "VerticalCaption", title: "$02020025_BF__main__3$", desc: "$02020025_BF__main__4$", align: "centerLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2f);
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
                context.CreateMonster(arg1: new[] {202});
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02020025_BF__main__5$", arg4: 5, arg5: 0);
                context.CameraSelect(arg1: 503, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_콘대르설명1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_콘대르설명1 : TriggerState {
            internal StateCamera_콘대르설명1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Talk_B", arg3: 18430f);
                context.AddCinematicTalk(npcId: 24110001, msg: "$02020025_BF__main__0$", duration: 4000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State유저Cinematic_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저Cinematic_2 : TriggerState {
            internal State유저Cinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02020025_BF__main__6$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State유저Cinematic_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저Cinematic_3 : TriggerState {
            internal State유저Cinematic_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 504, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera_콘대르설명2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_콘대르설명2 : TriggerState {
            internal StateCamera_콘대르설명2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24110001, illustId: "Conder_normal", msg: "$02020025_BF__main__1$", duration: 4000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_콘대르설명3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_콘대르설명3 : TriggerState {
            internal StateCamera_콘대르설명3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24110001, illustId: "Conder_normal", msg: "$02020025_BF__main__2$", duration: 4000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_콘대르설명4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_콘대르설명4 : TriggerState {
            internal StateCamera_콘대르설명4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24110001, illustId: "Conder_normal", msg: "$02020025_BF__main__7$", duration: 4000, align: "left");
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
            }

            public override TriggerState Execute() {
                return new StateSetup(context);
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: false, arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 902, arg2: new[] {201}) && context.WaitTick(waitTick: 2000)) {
                    return new State전투_진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_진행 : TriggerState {
            internal State전투_진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008}, arg2: false);
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
                    context.SideNpcTalk(npcId: 24110001, illust: "Conder_normal", duration: 5000, script: "$02020025_BF__main__8$", voice: @"ko/Npc/00002146");
                    return new State던전종료_A랭크이상(context);
                }

                if (context.GetDungeonFirstUserMissionScore() < 1500) {
                    context.SideNpcTalk(npcId: 24110001, illust: "Conder_smile", duration: 5000, script: "$02020025_BF__main__9$", voice: @"ko/Npc/00002145");
                    return new State던전종료_A랭크미만(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료_A랭크이상 : TriggerState {
            internal State던전종료_A랭크이상(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
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
                context.DestroyMonster(arg1: new[] {201});
                context.DungeonFail();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}