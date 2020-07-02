namespace Maple2.Trigger._52020027_qd {
    public static class _52020027_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "Boss", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new State연출감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출감지 : TriggerState {
            internal State연출감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {902})) {
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
                context.MoveUser(arg1: 52020027, arg2: 2);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Sit_Down_A", arg3: 5000f);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_세리하대사1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_세리하대사1 : TriggerState {
            internal StateCamera_세리하대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 22000114, arg3: "대체 어딨는거지?", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_세리하대사2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_세리하대사2 : TriggerState {
            internal StateCamera_세리하대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 502, arg2: true);
                context.SetNpcRotation(arg1: 101, arg2: 180);
                context.SetConversation(arg1: 2, arg2: 22000114, arg3: "여기까지 쫓아왔어?", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_세리하대사3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_세리하대사3 : TriggerState {
            internal StateCamera_세리하대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 22000114, arg3: "이제 결판을 내자!!", arg4: 4);
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
                context.DestroyMonster(arg1: new[] {101});
                context.CameraReset(interpolationTime: 0.1f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateBoss시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss시작 : TriggerState {
            internal StateBoss시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: true);
                context.SetUserValue(triggerId: 99990002, key: "Boss", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {111})) {
                    return new StateBoss종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss종료 : TriggerState {
            internal StateBoss종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetAchievement(arg1: 904, arg3: "KritiasScrimmage");
                context.SetEventUI(arg1: 1, arg2: "연출들어갈 예정입니다", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020006, arg2: 6001);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}