using System;

namespace Maple2.Trigger._52020001_qd {
    public static class _main_2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State2차감지(context);

        private class State2차감지 : TriggerState {
            internal State2차감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "2")) {
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

            public override void OnExit() {
                context.SetEventUI(arg1: 1, arg2: "폭격이 더욱 거세집니다. 서둘러 이동하세요!", arg3: new int[] {4000});
            }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "101", arg2: 180, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State몬스터출현_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현_3 : TriggerState {
            internal State몬스터출현_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {6100002}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000011}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000012}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000013}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터사망_3(context);
                    return;
                }

                if (context.TimeExpired(arg1: "101")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터사망_3 : TriggerState {
            internal State몬스터사망_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {6000011})
                    && context.MonsterDead(arg1: new int[] {6000012})
                    && context.MonsterDead(arg1: new int[] {6000013})) {
                    context.State = new State몬스터출현_4(context);
                    return;
                }

                if (context.TimeExpired(arg1: "101")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현_4 : TriggerState {
            internal State몬스터출현_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {6000014}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000015}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000016}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터사망_4(context);
                    return;
                }

                if (context.TimeExpired(arg1: "101")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터사망_4 : TriggerState {
            internal State몬스터사망_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {6000014})
                    && context.MonsterDead(arg1: new int[] {6000015})
                    && context.MonsterDead(arg1: new int[] {6000016})) {
                    context.State = new State생성_2(context);
                    return;
                }

                if (context.TimeExpired(arg1: "101")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성_2 : TriggerState {
            internal State생성_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "101");
                context.SetInteractObject(arg1: new int[] {10002002}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State작동_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State작동_2 : TriggerState {
            internal State작동_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002002}, arg2: 0)) {
                    context.State = new State연출시작_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작_2 : TriggerState {
            internal State연출시작_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {6100002});
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
                context.CameraSelectPath(arg1: new int[] {2000005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State폭발_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발_2 : TriggerState {
            internal State폭발_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {10001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State맵폭발연출_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵폭발연출_1 : TriggerState {
            internal State맵폭발연출_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {10031}, arg2: true);
                context.SetSkill(arg1: new int[] {6004}, arg2: true);
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
                context.CameraSelectPath(arg1: new int[] {2000006}, arg2: false);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
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
                context.MoveUser(arg1: 52020001, arg2: 12);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new State카메라리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋 : TriggerState {
            internal State카메라리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 16, arg2: true, arg3: true, arg4: false);
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
    }
}