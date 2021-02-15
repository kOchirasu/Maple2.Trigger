namespace Maple2.Trigger._52020001_qd {
    public static class _main_4 {
        public class State2차감지 : TriggerState {
            internal State2차감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002010}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {4})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State카메리이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카메리이동 : TriggerState {
            internal State카메리이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2000010}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State탈것Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것Appear : TriggerState {
            internal State탈것Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {7001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State폭발_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발_1 : TriggerState {
            internal State폭발_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10052}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State폭발_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발_2 : TriggerState {
            internal State폭발_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10053}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State폭발_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발_3 : TriggerState {
            internal State폭발_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10054}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State맵폭발Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵폭발Cinematic : TriggerState {
            internal State맵폭발Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10051}, arg2: true);
                context.SetSkill(arg1: new[] {6007}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4400)) {
                    return new StateCinematic끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic끝 : TriggerState {
            internal StateCinematic끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2000010}, arg2: true);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {6100004}, arg2: false);
            }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "좋아! 이 녀석을 타고 돌격해야겠어!!", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10002010}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateInteractObject_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject_2 : TriggerState {
            internal StateInteractObject_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002010}, arg2: 0)) {
                    return new StateInteractObject_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject_3 : TriggerState {
            internal StateInteractObject_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002010}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateCameraCinematic(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {7001}, arg2: false);
            }
        }

        private class StateCameraCinematic : TriggerState {
            internal StateCameraCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "출력이 부족해 크리티아스로 진입할 수 없습니다.", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State알림_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알림_2 : TriggerState {
            internal State알림_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"적들을 처치하면 에너지를 충전할 수 있습니다.\n제한시간 내에 100%충전해, 크리티아스로 진입하세요!", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State타이머시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "110", arg2: 360, arg3: true, arg4: true, arg5: 80);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {6000030, 6000031, 6000032, 6000033, 6000034}, arg2: false);
                context.SetUserValue(triggerId: 909, key: "respawn", value: 1);
                context.SetUserValue(triggerId: 910, key: "respawn", value: 1);
                context.SetUserValue(triggerId: 911, key: "respawn", value: 1);
                context.SetUserValue(triggerId: 912, key: "respawn", value: 1);
                context.SetUserValue(triggerId: 913, key: "respawn", value: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "110")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2000009}, arg2: true);
                context.SetEffect(arg1: new[] {10090, 10091, 10092}, arg2: true);
                context.SetMesh(arg1: new[] {80000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetEventUI(arg1: 1, arg2: "미션에 실패하였습니다. 다시 재도전 해보세요.", arg3: 4000);
                context.MoveUser(arg1: 52020001, arg2: 99);
                context.SetPortal(arg1: 14, arg2: true, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}