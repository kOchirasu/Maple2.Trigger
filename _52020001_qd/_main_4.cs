using System;

namespace Maple2.Trigger._52020001_qd {
    public static class _main_4 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State2차감지(context);

        private class State2차감지 : TriggerState {
            internal State2차감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002010}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {4})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State카메리이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메리이동 : TriggerState {
            internal State카메리이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000010}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State탈것등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈것등장 : TriggerState {
            internal State탈것등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {7001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State폭발_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발_1 : TriggerState {
            internal State폭발_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {10052}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State폭발_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발_2 : TriggerState {
            internal State폭발_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {10053}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State폭발_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발_3 : TriggerState {
            internal State폭발_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {10054}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State맵폭발연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵폭발연출 : TriggerState {
            internal State맵폭발연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {10051}, arg2: true);
                context.SetSkill(arg1: new int[] {6007}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4400)) {
                    context.State = new State연출끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출끝 : TriggerState {
            internal State연출끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000010}, arg2: true);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {6100004}, arg2: false);
            }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "좋아! 이 녀석을 타고 돌격해야겠어!!", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new int[] {10002010}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State오브젝트반응_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응_2 : TriggerState {
            internal State오브젝트반응_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002010}, arg2: 0)) {
                    context.State = new State오브젝트반응_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응_3 : TriggerState {
            internal State오브젝트반응_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002010}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State카메라연출(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {7001}, arg2: false);
            }
        }

        private class State카메라연출 : TriggerState {
            internal State카메라연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "출력이 부족해 크리티아스로 진입할 수 없습니다.", arg3: new int[] {4000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State알림_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알림_2 : TriggerState {
            internal State알림_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"적들을 처치하면 에너지를 충전할 수 있습니다.\n제한시간 내에 100%충전해, 크리티아스로 진입하세요!",
                    arg3: new int[] {4000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State타이머시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "110", arg2: 360, arg3: true, arg4: true, arg5: 80);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {6000030}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000031}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000032}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000033}, arg2: false);
                context.CreateMonster(arg1: new int[] {6000034}, arg2: false);
                context.SetUserValue(triggerID: 909, key: "respawn", value: 1);
                context.SetUserValue(triggerID: 910, key: "respawn", value: 1);
                context.SetUserValue(triggerID: 911, key: "respawn", value: 1);
                context.SetUserValue(triggerID: 912, key: "respawn", value: 1);
                context.SetUserValue(triggerID: 913, key: "respawn", value: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "110")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000009}, arg2: true);
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