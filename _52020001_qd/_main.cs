namespace Maple2.Trigger._52020001_qd {
    public static class _main {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {40001}, arg2: false);
                context.SetSkill(arg1: new[] {6001}, arg2: false);
                context.SetInteractObject(arg1: new[] {10002001}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10002002}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10002003}, arg2: 2);
                context.CreateMonster(arg1: new[] {6000020}, arg2: false);
                context.SetEffect(arg1: new[] {10090}, arg2: false);
                context.SetEffect(arg1: new[] {10091}, arg2: false);
                context.SetEffect(arg1: new[] {10092}, arg2: false);
                context.SetMesh(arg1: new[] {80000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 14, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {5})) {
                    context.State = new State인트로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로 : TriggerState {
            internal State인트로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State인트로_카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로_카메라 : TriggerState {
            internal State인트로_카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 2000012, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State인트로_폭발_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로_폭발_1 : TriggerState {
            internal State인트로_폭발_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10011}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State인트로_폭발_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로_폭발_2 : TriggerState {
            internal State인트로_폭발_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10012}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State인트로_폭발_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로_폭발_3 : TriggerState {
            internal State인트로_폭발_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10013}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State인트로_폭발_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로_폭발_4 : TriggerState {
            internal State인트로_폭발_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10014}, arg2: true);
                context.SetSkill(arg1: new[] {6001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new State인트로_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로_종료 : TriggerState {
            internal State인트로_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
                context.CameraSelect(arg1: 2000012, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1,
                    arg2: @"시간이 얼마 없습니다.\n폭격을 일삼는 에고웨폰들을 처치하며 크리티아스로 침투하세요.", arg3: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1})) {
                    context.State = new State타이머시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "100", arg2: 180, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State몬스터출현_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현_1 : TriggerState {
            internal State몬스터출현_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {40001}, arg2: true);
                context.CreateMonster(arg1: new[] {6000001}, arg2: false);
                context.CreateMonster(arg1: new[] {6000002}, arg2: false);
                context.CreateMonster(arg1: new[] {6000003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터사망_1(context);
                    return;
                }

                if (context.TimeExpired(arg1: "100")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "서둘러야 해!", arg4: 3, arg5: 0);
            }
        }

        private class State몬스터사망_1 : TriggerState {
            internal State몬스터사망_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {6000001})
                    && context.MonsterDead(arg1: new[] {6000002})
                    && context.MonsterDead(arg1: new[] {6000003})) {
                    context.State = new State몬스터출현_2(context);
                    return;
                }

                if (context.TimeExpired(arg1: "100")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현_2 : TriggerState {
            internal State몬스터출현_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {6000004}, arg2: false);
                context.CreateMonster(arg1: new[] {6000005}, arg2: false);
                context.CreateMonster(arg1: new[] {6000006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터사망_2(context);
                    return;
                }

                if (context.TimeExpired(arg1: "100")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터사망_2 : TriggerState {
            internal State몬스터사망_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {6000004})
                    && context.MonsterDead(arg1: new[] {6000005})
                    && context.MonsterDead(arg1: new[] {6000006})) {
                    context.State = new State스위치생성연출(context);
                    return;
                }

                if (context.TimeExpired(arg1: "100")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스위치생성연출 : TriggerState {
            internal State스위치생성연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "100");
                context.DestroyMonster(arg1: new[] {6100001});
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State스위치생성연출_카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스위치생성연출_카메라 : TriggerState {
            internal State스위치생성연출_카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 2000003, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State생성_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성_1 : TriggerState {
            internal State생성_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002001}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State스위치생성연출_카메라_초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스위치생성연출_카메라_초기화 : TriggerState {
            internal State스위치생성연출_카메라_초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
                context.CameraSelect(arg1: 2000003, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State작동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {6100001}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "저 스위치를 한번 작동시켜 볼까?", arg4: 3, arg5: 0);
            }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002001}, arg2: 0)) {
                    context.State = new State연출시작_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작_1 : TriggerState {
            internal State연출시작_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {6100001});
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State발사_카메라연출_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발사_카메라연출_1 : TriggerState {
            internal State발사_카메라연출_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 2000001, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State폭발배경연출_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발배경연출_1 : TriggerState {
            internal State폭발배경연출_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10028}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State폭발배경연출_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발배경연출_2 : TriggerState {
            internal State폭발배경연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10029}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State폭발_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발_1 : TriggerState {
            internal State폭발_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State날라감_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State날라감_1 : TriggerState {
            internal State날라감_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
                context.CameraSelectPath(arg1: new[] {2000002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statepc소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statepc소환 : TriggerState {
            internal Statepc소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 52020001, arg2: 11);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State폭발배경연출_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발배경연출_3 : TriggerState {
            internal State폭발배경연출_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10023}, arg2: true);
                context.SetSkill(arg1: new[] {6002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    context.State = new State폭발배경연출_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발배경연출_4 : TriggerState {
            internal State폭발배경연출_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10024}, arg2: true);
                context.SetSkill(arg1: new[] {6002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State폭발배경연출_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발배경연출_5 : TriggerState {
            internal State폭발배경연출_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10025}, arg2: true);
                context.SetSkill(arg1: new[] {6002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    context.State = new State맵폭발연출_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵폭발연출_1 : TriggerState {
            internal State맵폭발연출_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10021}, arg2: true);
                context.SetSkill(arg1: new[] {6002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new State맵폭발연출_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발배경연출_6 : TriggerState {
            internal State폭발배경연출_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10026}, arg2: true);
                context.SetSkill(arg1: new[] {6002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State폭발배경연출_7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발배경연출_7 : TriggerState {
            internal State폭발배경연출_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10027}, arg2: true);
                context.SetSkill(arg1: new[] {6002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State맵폭발연출_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵폭발연출_2 : TriggerState {
            internal State맵폭발연출_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10022}, arg2: true);
                context.SetSkill(arg1: new[] {6003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State카메라리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋 : TriggerState {
            internal State카메라리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 15, arg2: true, arg3: true, arg4: false);
                context.CameraReset(interpolationTime: 0.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) { }
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {10090}, arg2: true);
                context.SetEffect(arg1: new[] {10091}, arg2: true);
                context.SetEffect(arg1: new[] {10092}, arg2: true);
                context.SetMesh(arg1: new[] {80000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetEventUI(arg1: 1, arg2: "미션에 실패하였습니다. 다시 재도전 해보세요.", arg3: 4000);
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