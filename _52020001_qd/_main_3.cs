using System;

namespace Maple2.Trigger._52020001_qd {
    public static class _main_3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State2차감지(context);

        private class State2차감지 : TriggerState {
            internal State2차감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "3")) {
                    context.State = new State잠시기다림_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시기다림_1 : TriggerState {
            internal State잠시기다림_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State타이머시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "102", arg2: 180, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State몬스터출현_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현_5 : TriggerState {
            internal State몬스터출현_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {6100003}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000018}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000019}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터체력50(context);
                    return;
                }

                if (context.TimeExpired(arg1: "102")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터체력50 : TriggerState {
            internal State몬스터체력50(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 50, spawnPointId: 6000018, isRelative: "true")
                    || context.CheckNpcHp(compare: "lowerEqual", value: 50, spawnPointId: 6000019,
                        isRelative: "true")) {
                    context.State = new State생성_2(context);
                    return;
                }

                if (context.TimeExpired(arg1: "102")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성_2 : TriggerState {
            internal State생성_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {6000018}, arg2: 49286001, arg3: 1, arg4: true);
                context.AddBuff(arg1: new int[] {6000019}, arg2: 49286001, arg3: 1, arg4: true);
                context.ResetTimer(arg1: "102");
                context.SetInteractObject(arg1: new int[] {10002003}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "아크레온이 거대해지며 모든공격을 튕겨내기 시작했습니다.", arg3: new int[] {4000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State작동_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 921, key: "respawn", value: 1);
            }
        }

        private class State작동_2 : TriggerState {
            internal State작동_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002003}, arg2: 0)) {
                    context.State = new State연출시작_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 921, key: "respawn_end", value: 2);
            }
        }

        private class State연출시작_2 : TriggerState {
            internal State연출시작_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {6100003});
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000007}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State폭발_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발_2 : TriggerState {
            internal State폭발_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {10002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    context.State = new State맵폭발연출_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵폭발연출_1 : TriggerState {
            internal State맵폭발연출_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {10041}, arg2: true);
                context.SetSkill(arg1: new int[] {6005}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    context.State = new State카메라연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라연출 : TriggerState {
            internal State카메라연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000008}, arg2: false);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
                context.DestroyMonster(arg1: new int[] {6000018});
                context.DestroyMonster(arg1: new int[] {6000019});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statepc소환_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statepc소환_2 : TriggerState {
            internal Statepc소환_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 52020001, arg2: 13);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State맵폭발연출_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵폭발연출_2 : TriggerState {
            internal State맵폭발연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {10042}, arg2: true);
                context.SetSkill(arg1: new int[] {6006}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    context.State = new State카메라리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋 : TriggerState {
            internal State카메라리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 17, arg2: true, arg3: true, arg4: false);
                context.CameraReset(interpolationTime: 0.8f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {10090}, arg2: true);
                context.SetEffect(arg1: new int[] {10091}, arg2: true);
                context.SetEffect(arg1: new int[] {10092}, arg2: true);
                context.SetMesh(arg1: new int[] {80000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetEventUI(arg1: 1, arg2: "미션에 실패하였습니다. 다시 재도전 해보세요.", arg3: new int[] {4000});
                context.MoveUser(arg1: 52020001, arg2: 99);
                context.SetPortal(arg1: 14, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) { }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) { }
            }

            public override void OnExit() { }
        }
    }
}