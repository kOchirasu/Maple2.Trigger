namespace Maple2.Trigger._52020001_qd {
    public static class _main_3 {
        public class State2차감지 : TriggerState {
            internal State2차감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {3})) {
                    return new State잠시기다림_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시기다림_1 : TriggerState {
            internal State잠시기다림_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State타이머시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "102", arg2: 180, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateMonsterSpawn_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_5 : TriggerState {
            internal StateMonsterSpawn_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {6100003, 6000018, 6000019}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonster체력50(context);
                }

                if (context.TimeExpired(arg1: "102")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster체력50 : TriggerState {
            internal StateMonster체력50(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 6000018) <= 0.50f || context.GetNpcHpRate(spawnPointId: 6000019) <= 0.50f) {
                    return new StateCreation_2(context);
                }

                if (context.TimeExpired(arg1: "102")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation_2 : TriggerState {
            internal StateCreation_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {6000018}, arg2: 49286001, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {6000019}, arg2: 49286001, arg3: 1, arg4: true);
                context.ResetTimer(arg1: "102");
                context.SetInteractObject(arg1: new[] {10002003}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "아크레온이 거대해지며 모든공격을 튕겨내기 시작했습니다.", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State작동_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 921, key: "respawn", value: 1);
            }
        }

        private class State작동_2 : TriggerState {
            internal State작동_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002003}, arg2: 0)) {
                    return new StateStartCinematic_2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 921, key: "respawn_end", value: 2);
            }
        }

        private class StateStartCinematic_2 : TriggerState {
            internal StateStartCinematic_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {6100003});
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 1);
                context.VisibleMyPc(isVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2000007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State폭발_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발_2 : TriggerState {
            internal State폭발_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new State맵폭발연출_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵폭발연출_1 : TriggerState {
            internal State맵폭발연출_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10041}, arg2: true);
                context.SetSkill(arg1: new[] {6005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateCamera연출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera연출 : TriggerState {
            internal StateCamera연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2000008}, arg2: false);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 0);
                context.DestroyMonster(arg1: new[] {6000018, 6000019});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePc소환_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePc소환_2 : TriggerState {
            internal StatePc소환_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 52020001, arg2: 13);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State맵폭발연출_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵폭발연출_2 : TriggerState {
            internal State맵폭발연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10042}, arg2: true);
                context.SetSkill(arg1: new[] {6006}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateCamera리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋 : TriggerState {
            internal StateCamera리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 17, arg2: true, arg3: true, arg4: false);
                context.CameraReset(interpolationTime: 0.8f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) { }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}