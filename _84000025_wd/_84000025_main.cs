namespace Maple2.Trigger._84000025_wd {
    public static class _84000025_main {
        public class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Weddingceremonystarts", value: 0);
                context.SetPortal(arg1: 99, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State결혼식연출시작요청대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결혼식연출시작요청대기 : TriggerState {
            internal State결혼식연출시작요청대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: false);
                context.HideGuideSummary(entityId: 28400140);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Weddingceremonystarts") == 1) {
                    context.SetUserValue(key: "Weddingceremonystarts", value: 0);
                    context.LockMyPc(isLock: true);
                    context.State = new State시작알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작알림 : TriggerState {
            internal State시작알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400134, textId: 28400134);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400134);
            }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000025, arg2: new byte[] {22, 23}, arg3: 701);
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000025, arg2: new byte[] {22, 23}, arg3: 703);
                context.WeddingMoveUser(entryType: "Groom", arg1: 84000025, arg2: new byte[] {11}, arg3: 702);
                context.WeddingMoveUser(entryType: "Bride", arg1: 84000025, arg2: new byte[] {12}, arg3: 702);
                context.SetPortal(arg1: 99, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State주례줌인01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State주례줌인01 : TriggerState {
            internal State주례줌인01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {8002, 8001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State주례줌인02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State주례줌인02 : TriggerState {
            internal State주례줌인02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11004710, msg: "$84000025_WD__84000025_MAIN__0$", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State시선돌리기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시선돌리기01 : TriggerState {
            internal State시선돌리기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세레나데(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세레나데 : TriggerState {
            internal State세레나데(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateUI테스트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateUI테스트 : TriggerState {
            internal StateUI테스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State입장준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입장준비01 : TriggerState {
            internal State입장준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8009}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State입장준비02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입장준비02 : TriggerState {
            internal State입장준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingSetUserEmotion(entryType: "Bride", id: 6);
                context.WeddingSetUserEmotion(entryType: "Groom", id: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State입장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입장01 : TriggerState {
            internal State입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004, 8005, 8011}, arg2: false);
                context.WeddingUserToPatrol(patrolName: "MS2PatrolData_2001", entryType: "Groom", patrolIndex: 1);
                context.WeddingUserToPatrol(patrolName: "MS2PatrolData_2002", entryType: "Bride", patrolIndex: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동01 : TriggerState {
            internal State카메라이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State카메라이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동02 : TriggerState {
            internal State카메라이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State주례사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State주례사 : TriggerState {
            internal State주례사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11004710, msg: "$84000025_WD__84000025_MAIN__1$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State성혼타이핑결과확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성혼타이핑결과확인 : TriggerState {
            internal State성혼타이핑결과확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMutualAgree(agreeType: "partnerName");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.WeddingMutualCancel(agreeType: "partnerName");
                    context.State = new State미입력으로중단01(context);
                    return;
                }

                if (context.WeddingEntryInField(entryType: "GroomBride", isInField: false)) {
                    context.WeddingMutualCancel(agreeType: "partnerName");
                    context.State = new State탈주로중단(context);
                    return;
                }

                if (context.WeddingMutualAgreeResult(agreeType: "partnerName", success: false)) {
                    context.State = new State탈주로중단(context);
                    return;
                }

                if (context.WeddingMutualAgreeResult(agreeType: "partnerName", success: true)) {
                    context.State = new State성혼발표(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈주로중단 : TriggerState {
            internal State탈주로중단(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004710, msg: "$84000025_WD__84000025_MAIN__2$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State탈주로중단선언(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈주로중단선언 : TriggerState {
            internal State탈주로중단선언(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004710, msg: "$84000025_WD__84000025_MAIN__3$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State탈주로중단선언리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미입력으로중단01 : TriggerState {
            internal State미입력으로중단01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004710, msg: "$84000025_WD__84000025_MAIN__4$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State미입력으로중단선언(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미입력으로중단선언 : TriggerState {
            internal State미입력으로중단선언(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004710, msg: "$84000025_WD__84000025_MAIN__5$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State탈주로중단선언리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈주로중단선언리셋 : TriggerState {
            internal State탈주로중단선언리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4002, key: "Weddingceremonyfail", value: 1);
                context.SetUserValue(triggerId: 4000, key: "Weddingceremonyfail", value: 1);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State결혼식연출시작요청대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성혼발표 : TriggerState {
            internal State성혼발표(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004710, msg: "$84000025_WD__84000025_MAIN__6$", duration: 2500);
                context.WeddingVowComplete();
                context.SetUserValue(triggerId: 4002, key: "WeddingFinished", value: 1);
                context.WeddingSetUserLookAt(entryType: "Bride", lookAtEntryType: "Groom", immediate: true);
                context.WeddingSetUserLookAt(entryType: "Groom", lookAtEntryType: "Bride", immediate: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State환호성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State환호성 : TriggerState {
            internal State환호성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.WeddingSetUserEmotion(entryType: "Bride", id: 4);
                context.WeddingSetUserEmotion(entryType: "Groom", id: 4);
                context.PlaySystemSoundInBox(arg2: "System_WeddingAudience_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State뒷풀이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State뒷풀이01 : TriggerState {
            internal State뒷풀이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보상과결혼상태마지막체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보상과결혼상태마지막체크 : TriggerState {
            internal State보상과결혼상태마지막체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: false);
            }

            public override void Execute() {
                if (context.WeddingHallState(hallState: "weddingComplete", success: true)) {
                    context.State = new State뒷풀이02(context);
                    return;
                }

                if (true) {
                    context.State = new State보상결혼상태체크실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보상결혼상태체크실패 : TriggerState {
            internal State보상결혼상태체크실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4002, key: "Weddingceremonyfail", value: 1);
                context.SetUserValue(triggerId: 4000, key: "Weddingceremonyfail", value: 1);
                context.ShowGuideSummary(entityId: 28400140);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State결혼식연출시작요청대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State뒷풀이02 : TriggerState {
            internal State뒷풀이02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400135, textId: 28400135);
                context.SetPortal(arg1: 99, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State뒷풀이03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400135);
            }
        }

        private class State뒷풀이03 : TriggerState {
            internal State뒷풀이03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400136, textId: 28400136);
                context.SetUserValue(key: "EndWedding", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "EndWedding") == 1) {
                    context.State = new State결혼종료확인(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400136);
            }
        }

        private class State결혼종료확인 : TriggerState {
            internal State결혼종료확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMutualAgree(agreeType: "endActing");
            }

            public override void Execute() {
                if (context.WeddingEntryInField(entryType: "GroomBride", isInField: false)) {
                    context.State = new State종료알림(context);
                    return;
                }

                if (context.WeddingMutualAgreeResult(agreeType: "endActing", success: true)) {
                    context.State = new State종료알림(context);
                    return;
                }

                if (context.WeddingMutualAgreeResult(agreeType: "endActing", success: false)) {
                    context.State = new State뒷풀이03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료알림 : TriggerState {
            internal State종료알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400137, textId: 28400137);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new State끄읏(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400137);
            }
        }

        private class State끄읏 : TriggerState {
            internal State끄읏(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}